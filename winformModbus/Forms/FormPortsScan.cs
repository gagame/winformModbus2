using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformModbus.Forms
{
    public partial class FormPortsScan : Form
    {
        private static FormPortsScan instance;
        public static FormPortsScan getInstance()
        {
            if (instance == null)
                instance = new FormPortsScan();
            return instance;
        }

        List<MyPort> ports = new List<MyPort>();
        List<MyPort2> ports2 = new List<MyPort2>();
        GlobalVariable g1 = GlobalVariable.getInstance();

        public FormPortsScan()
        {
            InitializeComponent();
        }
        private void showMsg(string port, string msg, int br, int db, int sb, int pr,int poll,int resp)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                richTextBox.AppendText($"{port},BaudRate:{br},DataBit:{db},StopBit:{sb},Parity:{pr},Message:{msg},poll:{poll}response:{resp},accuracy:{(float)resp / (float)poll}\n");
                //richTextBox.AppendText($"{port},BaudRate:{br},DataBit:{db},StopBit:{sb},Parity:{pr},Message:{msg}\n");
            }));
        }
        private void showMsg(string port, string msg, int br, int db, int sb, int pr)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                richTextBox.AppendText($"{port},BaudRate:{br},DataBit:{db},StopBit:{sb},Parity:{pr},Message:{msg}\n");
                //richTextBox.AppendText($"{port},BaudRate:{br},DataBit:{db},StopBit:{sb},Parity:{pr},Message:{msg}\n");
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ports.Clear();
            foreach (string port in SerialPort.GetPortNames())
            {
                ports.Add(new MyPort(port));
            }

            foreach (MyPort port in ports)
            {
                port._OnMessageHandler += showMsg;
                port.start();
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }
        public string GetScanRichText
        {
            get { return richTextBox.Text; }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ports2.Clear();
            foreach (string port in SerialPort.GetPortNames())
            {
                ports2.Add(new MyPort2(port));
            }

            foreach (MyPort2 port in ports2)
            {
                port._OnMessageHandler += showMsg;
                port.start();
            }
        }
    }
}
