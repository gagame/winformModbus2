using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//"01 04 00 00 00 02 71 CB", "04 04 00 00 00 02 71 9E", "05 04 00 00 00 02 70 4F"

namespace winformModbus.Forms
{
    public partial class FormCommand : Form
    {
        private static FormCommand instance;
        public static FormCommand getInstance()
        {
            if (instance == null)
                instance = new FormCommand();
            return instance;
        }

        SerialPort port = new SerialPort();
        string _receiveMode = "HEX";
        GlobalVariable g1 = GlobalVariable.getInstance();

        public FormCommand()
        {
            InitializeComponent();
        }

        private void FormCommand_Load(object sender, EventArgs e)
        {
            port.ReadBufferSize = 50;
            port.ReadTimeout = 600;
            port.DataReceived += Port_DataReceived;
            richTextBox.HideSelection = false;
            loadComPortList();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_DEVICECHANGE = 0x219;
            const int USB_REMOVE = 32772;
            const int USB_INSTALL = 32768;

            object ojb = new object();
            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    if (m.WParam.ToInt32() == USB_REMOVE || m.WParam.ToInt32() == USB_INSTALL)
                    {
                        loadComPortList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            base.WndProc(ref m);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            close_app();
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (_receiveMode == "HEX")
                {
                    Byte[] buffer = new Byte[port.BytesToRead];
                    Int32 length = port.Read(buffer, 0, buffer.Length);
                    StringBuilder strBuider = new StringBuilder();
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        for (int index = 0; index < buffer.Length; index++)
                        {
                            strBuider.Append(((int)buffer[index]).ToString("X2") + " ");
                        }
                        showMsg(strBuider.ToString(), Color.Red, false);
                    }));
                }
                else
                {
                    Byte[] buffer = new Byte[port.BytesToRead];
                    Int32 length = port.Read(buffer, 0, buffer.Length);
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        showMsg(Encoding.ASCII.GetString(buffer), Color.Red, false);
                    }));
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void showMsg(string txt, Color color, bool IsSend)
        {
            if (IsSend) OnAppend("T  -> ", color);
            else OnAppend("R <- ", color);
            if (enableShowTime.Checked) OnAppend($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff")}]：", color);
            OnAppend(txt, color);
            OnAppend("\n", color);
            if (endText.Text == "CR" && IsSend) OnAppend("\r", color);
            else if (endText.Text == "NL" && IsSend) OnAppend("\n", color);
            else if (endText.Text == "NL_CR" && IsSend) OnAppend("\n", color);
        }

        private byte[] ToByte(string s)
        {
            return s.Split(' ').AsParallel().Select(x => Convert.ToByte(x, 16)).ToArray();
        }

        private void SendText(string sData)
        {
            string tmp = sData;
            byte[] tmp1 = new byte[tmp.Length];
            byte[] tmp2 = new byte[tmp.Length + 2];
            if (transferMode.Text == "HEX") tmp1 = ToByte(tmp);

            if (transferMode.Text == "HEX")
            {
                if (containCRC.Checked)
                {
                    //SendData(tmp1);
                    SendData(g1.CRC16LH(tmp1));
                }
                else
                {
                    SendData(tmp1);
                }
                if (enableShowSend.Checked) showMsg(sData + '\n', Color.FromArgb(0, 72, 158, 226), true);
            }
            else
            {
                if (endText.Text == "CR") SendData(Encoding.ASCII.GetBytes(sData + "\r"));
                else if (endText.Text == "NL") SendData(Encoding.ASCII.GetBytes(sData + "\n"));
                else if (endText.Text == "NL_CR") SendData(Encoding.ASCII.GetBytes(sData + "\n\r"));
                if (enableShowSend.Checked) showMsg(sData, Color.FromArgb(0, 72, 158, 226), true);

            }
        }

        private void SendData(byte[] sendBuffer)
        {
            if (sendBuffer != null)
            {
                try
                {
                    port.Write(sendBuffer, 0, sendBuffer.Length);
                }
                catch
                {

                }
            }
        }

        void OnAppend(string text, Color color)
        {
            bool focused = richTextBox.Focused;
            int selection = richTextBox.SelectionStart;
            int length = richTextBox.SelectionLength;
            bool autoscroll = enableAutoScroll.Checked;

            richTextBox.SelectionColor = color;

            if (!autoscroll)
            {
                if (focused) richTextBox.Focus();
                //SendMessage(richTextBox.Handle, EM_HIDESELECTION, 1, 0);
                richTextBox.SelectionColor = color;
            }

            richTextBox.AppendText(text);

            if (!autoscroll)
            {
                richTextBox.SelectionStart = selection;
                richTextBox.SelectionLength = length;
                //SendMessage(richTextBox.Handle, EM_HIDESELECTION, 0, 0);
                richTextBox.SelectionColor = color;
                if (focused) richTextBox.Focus();
            }
        }

        private void loadComPortList()
        {
            comPortList.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comPortList.Items.AddRange(ports);
        }

        private void close_app()
        {
            if (port.IsOpen)
            {
                port.Close();
            }
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendText(textBox1.Text);
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    GC.Collect();
                    port.PortName = comPortList.Text;
                    port.BaudRate = Convert.ToInt32(baudRateList.Text);
                    port.StopBits = (stopBitsList.Text == "One") ? StopBits.One : StopBits.Two;
                    if (parityList.Text == "None") port.Parity = Parity.None;
                    else if (parityList.Text == "Odd") port.Parity = Parity.Odd;
                    else if (parityList.Text == "Even") port.Parity = Parity.Even;
                    else if (parityList.Text == "Space") port.Parity = Parity.Space;

                    port.Open();
                    port.DiscardInBuffer();
                    port.DiscardOutBuffer();
                }
                else if (port.IsOpen)
                {
                    port.DiscardInBuffer();
                    port.DiscardOutBuffer();
                    port.Close();
                    GC.Collect();
                }
            }
            catch (Exception ex)
            {
                OnAppend(ex.Message, Color.Purple);
                OnAppend("\n", Color.Purple);
            }

            if (port.IsOpen)
            {
                connectBtn.Text = "Disconnect";
            }
            else
            {
                connectBtn.Text = "Connect";
            }
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void receiveMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _receiveMode = receiveMode.Text;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SendText(textBox1.Text);
        }

    }
}