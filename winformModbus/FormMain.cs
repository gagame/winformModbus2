using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace winformModbus
{
    public partial class FormMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form formCommand = Forms.FormCommand.getInstance();
        private Form formPortsScan = Forms.FormPortsScan.getInstance();
        private Form formStatistic = Forms.FormStatistic.getInstance();
        private Form formOptimization = Forms.FormOptimization.getInstance();
        public FormMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,55);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = currentBtn.IconColor;
            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.MidnightBlue;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void PortsScanBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            formCommand.Hide();
            formOptimization.Hide();
            formStatistic.Hide();
            formPortsScan.BringToFront();
            formPortsScan.Show();
            labelTitleChildForm.Text = formCommand.Text;
        }

        private void CommandBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            formOptimization.Hide();
            formPortsScan.Hide();
            formStatistic.Hide();
            formCommand.BringToFront();
            formCommand.Show();
            labelTitleChildForm.Text = formCommand.Text;
        }

        private void StatisticBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            //OpenChildForm(new Forms.FormStatistic());
            formCommand.Hide();
            formOptimization.Hide();
            formPortsScan.Hide();
            formStatistic.BringToFront();
            formStatistic.Show();
            labelTitleChildForm.Text = formStatistic.Text;
        }

        private void OptimizationBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            //OpenChildForm(new Forms.FormOptimization());
            formCommand.Hide();
            formPortsScan.Hide();
            formStatistic.Hide();
            formOptimization.BringToFront();
            formOptimization.Show();
            labelTitleChildForm.Text = formOptimization.Text;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            //currentChildForm.Close();
            formCommand.Hide();
            formOptimization.Hide();
            formPortsScan.Hide();
            formStatistic.Hide();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Lavender;
            labelTitleChildForm.Text = "Home";
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //formCommand = new Forms.FormCommand();
            formCommand.TopLevel = false;
            formCommand.FormBorderStyle = FormBorderStyle.None;
            formCommand.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(formCommand);
            panelDesktop.Tag = formCommand;

            //formOptimization = new Forms.FormOptimization();
            formOptimization.TopLevel = false;
            formOptimization.FormBorderStyle = FormBorderStyle.None;
            formOptimization.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(formOptimization);
            panelDesktop.Tag = formOptimization;

            //formPortsScan = new Forms.FormPortsScan();
            formPortsScan.TopLevel = false;
            formPortsScan.FormBorderStyle = FormBorderStyle.None;
            formPortsScan.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(formPortsScan);
            panelDesktop.Tag = formPortsScan;

            //formStatistic = new Forms.FormStatistic();
            formStatistic.TopLevel = false;
            formStatistic.FormBorderStyle = FormBorderStyle.None;
            formStatistic.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(formStatistic);
            panelDesktop.Tag = formStatistic;
        }
    }
}
