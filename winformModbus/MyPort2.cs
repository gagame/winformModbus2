using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace winformModbus
{
    //public class MyPortType2
    //{
    //    public string portName;
    //    public int baudRate;
    //    public int dataBit;
    //    public int stopBit;
    //    public int parity;
    //    public int poll;
    //    public int response;

    //    public MyPortType2(string portName, int baudRate, int dataBit, int stopBit, int parity, int poll,int response)
    //    {
    //        this.portName = portName;
    //        this.baudRate = baudRate;
    //        this.dataBit = dataBit;
    //        this.stopBit = stopBit;
    //        this.parity = parity;
    //        this.poll = poll;
    //        this.response = response;
    //    }
    //}
    public class MyPort2
    {
        public delegate void EventHandler(string port, string msg, int br, int db, int sb, int pr,int poll,int response, bool checkCRC);
        public event EventHandler _OnMessageHandler;
        //private MyPortType2 myPortType;
        private string _portName;
        private int _portNum;
        private int _baudRate;
        private int _dataBit;
        private int _stopBit;
        private int _parity;
        private int _poll;
        private int _response;
        private int _address;
        private int _functionCode;
        private SerialPort port = new SerialPort();
        private BackgroundWorker worker = new BackgroundWorker();
        private bool _isOver = false;
        GlobalVariable g1 = GlobalVariable.getInstance();

        public MyPort2(string portName)
        {
            _portName = portName;
            port = new SerialPort(portName);
            port.DataReceived += Ports_DataReceived;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
        }

        public string portName
        {
            get
            {
                _portName = port.PortName;
                return _portName;
            }
        }
        public int portNum
        {
            get
            {
                if (port.PortName == "COM1") _portNum = 1;
                else if (port.PortName == "COM2") _portNum = 2;
                else if (port.PortName == "COM3") _portNum = 3;
                else if (port.PortName == "COM4") _portNum = 4;
                return _portNum;
            }
        }
        public int baudRate
        {
            get
            {
                _baudRate = port.BaudRate;
                return _baudRate;
            }
        }
        public int dataBit
        {
            get
            {
                _dataBit = port.DataBits;
                return _dataBit;
            }
        }
        public int stopBit
        {
            get
            {
                if (port.StopBits == StopBits.One) _stopBit = 1;
                else if (port.StopBits == StopBits.Two) _stopBit = 2;
                else if (port.StopBits == StopBits.None) _stopBit = 0;
                else _stopBit = 87;
                return _stopBit;
            }
        }
        public int parity
        {
            get
            {
                if (port.Parity == Parity.None) _parity = 0;
                else if (port.Parity == Parity.Odd) _parity = 1;
                else if (port.Parity == Parity.Even) _parity = 2;
                else _parity = 87;
                return _parity;
            }
        }

        private void Ports_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Byte[] buffer = new Byte[port.BytesToRead];
            Int32 length = port.Read(buffer, 0, buffer.Length);
            StringBuilder strBuider = new StringBuilder();
            for (int index = 0; index < buffer.Length; index++)
            {
                strBuider.Append(((int)buffer[index]).ToString("X2") + " ");
            }
            if(g1.CheckCRC16LH(buffer)) _response++;
            _OnMessageHandler?.Invoke(portName, strBuider.ToString(), baudRate, dataBit, stopBit, parity,_poll,_response, g1.CheckCRC16LH(buffer));
            _isOver = true;
        }

        public void start()
        {
            worker.RunWorkerAsync();

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {

            byte[] tmpByte = new byte[16];
            try
            {
                GC.Collect();
                DataAccess db = new DataAccess();
                port.BaudRate = 19200;//g1.BaudRateList[2];
                port.DataBits = 8;
                port.StopBits = StopBits.One;
                port.Parity = Parity.None;
                if (!port.IsOpen)
                {
                    port.Open();
                    port.DiscardInBuffer();
                    port.DiscardOutBuffer();
                }
                foreach(ComParam Param in g1.Params)
                {
                    if(Param.ComName == port.PortName&&Param.FunctionCode==4&&Param.Stopbit==1&&Param.Databit==8&&Param.Parity==0)
                    {
                        while (true)
                        {
                            int _timeOut = 0;
                            port.BaudRate = Param.Baud;
                            tmpByte = g1.ToByte($"0{Param.Address} 0{Param.FunctionCode} 00 00 00 01");
                            tmpByte = g1.CRC16LH(tmpByte);
                            port.Write(tmpByte, 0, tmpByte.Length);
                            _poll++;
                            _isOver = false;
                            //while (!_isOver)
                            //{
                            //    _timeOut++;
                            //    Thread.Sleep(1);
                            //    if (_timeOut > 30) _isOver = true;
                            //}
                            Thread.Sleep(50);
                            if (_poll >= 1000)
                            {
                                db.InsertModbusDB(portNum, baudRate, port.DataBits, stopBit, parity, Param.Address, Param.FunctionCode, _poll, _response);
                                _poll = 0;
                                _response = 0;
                                break;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                _isOver = true;
                Console.WriteLine($"Open:{portName} failed");
                return;
            }

        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (port.IsOpen)
            {
                //Console.WriteLine($"Close:{port.PortName} OK");
                Console.WriteLine($"Close:{_portName} OK");
                port.Close();
            }
            Console.WriteLine($"WorkerFinish:{_portName}");
        }
    }
}
