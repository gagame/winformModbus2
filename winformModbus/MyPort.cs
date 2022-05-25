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
    public class MyPortType
    {
        public string portName;
        public int baudRate;
        public int dataBit;
        public int stopBit;
        public int parity;

        public MyPortType(string portName, int baudRate, int dataBit, int stopBit, int parity)
        {
            this.portName = portName;
            this.baudRate = baudRate;
            this.dataBit = dataBit;
            this.stopBit = stopBit;
            this.parity = parity;
        }
    }
    public class MyPort
    {
        public delegate void EventHandler(string port, string msg, int br, int db, int sb, int pr);
        public event EventHandler _OnMessageHandler;
        private MyPortType myPortType;
        private string _portName;
        private int _baudRate;
        private int _dataBit;
        private int _stopBit;
        private int _parity;
        private SerialPort port = new SerialPort();
        private BackgroundWorker worker = new BackgroundWorker();
        private bool _isSuccess = false;
        private bool _isOver = false;
        GlobalVariable g1 = GlobalVariable.getInstance();

        public MyPort(string portName)
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
        public bool isSuccess
        {
            get
            {
                return _isSuccess;
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
            Console.WriteLine($"DataReveiced:{port.PortName},{baudRate},{dataBit},{stopBit},{parity},{strBuider.ToString()}");
            string[] strArray = strBuider.ToString().Split(' ');
            for(int i = 0; i < 10; i++)
            {
                if (strArray[0] == $"0{i+1}")
                {
                    g1.AddressBaud[i] = port.BaudRate;
                }
            } 
            myPortType = new MyPortType(portName, baudRate, dataBit, stopBit, parity);
            _OnMessageHandler?.Invoke(portName, strBuider.ToString(), baudRate, dataBit, stopBit, parity);
            _isOver = true;
        }

        public void start()
        {
            worker.RunWorkerAsync();

        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] tmpByte = new byte[16];
            for (int scanBaudRate = 0; scanBaudRate < 5; scanBaudRate++)
            {
                for (int scanDataBit = 0; scanDataBit < 2; scanDataBit++)
                {
                    for (int scanStopBit = 0; scanStopBit < 2; scanStopBit++)
                    {
                        for (int scanParity = 0; scanParity < 3; scanParity++)
                        {
                            int _timeOut = 0;
                            try
                            {
                                GC.Collect();
                                port.BaudRate = g1.BaudRateList[scanBaudRate];
                                port.DataBits = (scanDataBit == 0) ? 7 : 8;
                                port.StopBits = (scanStopBit == 0) ? StopBits.One : StopBits.Two;
                                if (scanParity == 0) port.Parity = Parity.None;
                                else if (scanParity == 1) port.Parity = Parity.Odd;
                                else if (scanParity == 2) port.Parity = Parity.Even;
                                if (!port.IsOpen)
                                {
                                    port.Open();
                                    port.DiscardInBuffer();
                                    port.DiscardOutBuffer();
                                }
                                if (port.IsOpen) Console.WriteLine($"Open:{portName},{baudRate},{dataBit},{stopBit},{parity} OK");
                                tmpByte = g1.ToByte(g1.SendDataList[0]);
                                port.Write(tmpByte, 0, tmpByte.Length);
                                _isOver = false;
                                while (!_isOver)
                                {
                                    _timeOut++;
                                    Thread.Sleep(1);
                                    if (_timeOut > 10) _isOver = true;
                                }
                                Thread.Sleep(50);
                                tmpByte = g1.ToByte(g1.SendDataList[1]);
                                port.Write(tmpByte, 0, tmpByte.Length);
                                _isOver = false;
                                while (!_isOver)
                                {
                                    _timeOut++;
                                    Thread.Sleep(1);
                                    if (_timeOut > 10) _isOver = true;
                                }
                                Thread.Sleep(50);
                                tmpByte = g1.ToByte(g1.SendDataList[2]);
                                port.Write(tmpByte, 0, tmpByte.Length);
                                _isOver = false;
                                while (!_isOver)
                                {
                                    _timeOut++;
                                    Thread.Sleep(1);
                                    if (_timeOut > 10) _isOver = true;
                                }
                                Thread.Sleep(50);
                                tmpByte = g1.ToByte(g1.SendDataList[3]);
                                port.Write(tmpByte, 0, tmpByte.Length);
                                _isOver = false;
                                while (!_isOver)
                                {
                                    _timeOut++;
                                    Thread.Sleep(1);
                                    if (_timeOut > 10) _isOver = true;
                                }
                                Thread.Sleep(50);
                            }
                            catch (Exception ex)
                            {
                                _isOver = true;
                                Console.WriteLine($"Open:{portName} failed");
                                return;
                            }
                            while (!_isOver)
                            {
                                _timeOut++;
                                if (_timeOut > 10) _isOver = true;
                            }
                        }
                    }
                }
            }
            foreach (int ab in g1.AddressBaud) Console.WriteLine(ab);
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
