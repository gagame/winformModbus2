namespace winformModbus.Forms
{
    partial class FormCommand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.transferMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.receiveMode = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cleanBtn = new System.Windows.Forms.Button();
            this.enableShowSend = new System.Windows.Forms.CheckBox();
            this.enableShowTime = new System.Windows.Forms.CheckBox();
            this.enableAutoScroll = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.stopBitsList = new System.Windows.Forms.ComboBox();
            this.dataBitsList = new System.Windows.Forms.ComboBox();
            this.parityList = new System.Windows.Forms.ComboBox();
            this.baudRateList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.comPortList = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendBtn = new System.Windows.Forms.Button();
            this.endText = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.containCRC = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 474);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.transferMode);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.receiveMode);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 330);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 121);
            this.panel6.TabIndex = 2;
            // 
            // transferMode
            // 
            this.transferMode.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.transferMode.FormattingEnabled = true;
            this.transferMode.Items.AddRange(new object[] {
            "Text",
            "HEX"});
            this.transferMode.Location = new System.Drawing.Point(13, 84);
            this.transferMode.Name = "transferMode";
            this.transferMode.Size = new System.Drawing.Size(101, 29);
            this.transferMode.TabIndex = 12;
            this.transferMode.Text = "HEX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(13, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Transfer Mode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(13, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Receive Mode:";
            // 
            // receiveMode
            // 
            this.receiveMode.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.receiveMode.FormattingEnabled = true;
            this.receiveMode.Items.AddRange(new object[] {
            "Text",
            "HEX"});
            this.receiveMode.Location = new System.Drawing.Point(13, 29);
            this.receiveMode.Name = "receiveMode";
            this.receiveMode.Size = new System.Drawing.Size(101, 29);
            this.receiveMode.TabIndex = 9;
            this.receiveMode.Text = "HEX";
            this.receiveMode.SelectedIndexChanged += new System.EventHandler(this.receiveMode_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.containCRC);
            this.panel5.Controls.Add(this.cleanBtn);
            this.panel5.Controls.Add(this.enableShowSend);
            this.panel5.Controls.Add(this.enableShowTime);
            this.panel5.Controls.Add(this.enableAutoScroll);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 206);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 124);
            this.panel5.TabIndex = 1;
            // 
            // cleanBtn
            // 
            this.cleanBtn.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.cleanBtn.Location = new System.Drawing.Point(130, 17);
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(82, 69);
            this.cleanBtn.TabIndex = 3;
            this.cleanBtn.Text = "Clean All";
            this.cleanBtn.UseVisualStyleBackColor = true;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // enableShowSend
            // 
            this.enableShowSend.AutoSize = true;
            this.enableShowSend.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.enableShowSend.Location = new System.Drawing.Point(3, 64);
            this.enableShowSend.Name = "enableShowSend";
            this.enableShowSend.Size = new System.Drawing.Size(121, 25);
            this.enableShowSend.TabIndex = 2;
            this.enableShowSend.Text = "Show Send";
            this.enableShowSend.UseVisualStyleBackColor = true;
            // 
            // enableShowTime
            // 
            this.enableShowTime.AutoSize = true;
            this.enableShowTime.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.enableShowTime.Location = new System.Drawing.Point(3, 38);
            this.enableShowTime.Name = "enableShowTime";
            this.enableShowTime.Size = new System.Drawing.Size(117, 25);
            this.enableShowTime.TabIndex = 1;
            this.enableShowTime.Text = "Show Time";
            this.enableShowTime.UseVisualStyleBackColor = true;
            // 
            // enableAutoScroll
            // 
            this.enableAutoScroll.AutoSize = true;
            this.enableAutoScroll.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.enableAutoScroll.Location = new System.Drawing.Point(3, 12);
            this.enableAutoScroll.Name = "enableAutoScroll";
            this.enableAutoScroll.Size = new System.Drawing.Size(119, 25);
            this.enableAutoScroll.TabIndex = 0;
            this.enableAutoScroll.Text = "Auto Scroll";
            this.enableAutoScroll.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.stopBitsList);
            this.panel4.Controls.Add(this.dataBitsList);
            this.panel4.Controls.Add(this.parityList);
            this.panel4.Controls.Add(this.baudRateList);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.connectBtn);
            this.panel4.Controls.Add(this.comPortList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 206);
            this.panel4.TabIndex = 0;
            // 
            // stopBitsList
            // 
            this.stopBitsList.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.stopBitsList.FormattingEnabled = true;
            this.stopBitsList.Items.AddRange(new object[] {
            "1 bit",
            "2 bits"});
            this.stopBitsList.Location = new System.Drawing.Point(100, 135);
            this.stopBitsList.Name = "stopBitsList";
            this.stopBitsList.Size = new System.Drawing.Size(94, 29);
            this.stopBitsList.TabIndex = 11;
            this.stopBitsList.Text = "1 bit";
            // 
            // dataBitsList
            // 
            this.dataBitsList.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dataBitsList.FormattingEnabled = true;
            this.dataBitsList.Items.AddRange(new object[] {
            "8 bits",
            "7 bits",
            "6 bits",
            "5 bits"});
            this.dataBitsList.Location = new System.Drawing.Point(100, 103);
            this.dataBitsList.Name = "dataBitsList";
            this.dataBitsList.Size = new System.Drawing.Size(94, 29);
            this.dataBitsList.TabIndex = 10;
            this.dataBitsList.Text = "8 bits";
            // 
            // parityList
            // 
            this.parityList.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.parityList.FormattingEnabled = true;
            this.parityList.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Space"});
            this.parityList.Location = new System.Drawing.Point(100, 71);
            this.parityList.Name = "parityList";
            this.parityList.Size = new System.Drawing.Size(94, 29);
            this.parityList.TabIndex = 9;
            this.parityList.Text = "None";
            // 
            // baudRateList
            // 
            this.baudRateList.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.baudRateList.FormattingEnabled = true;
            this.baudRateList.Items.AddRange(new object[] {
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.baudRateList.Location = new System.Drawing.Point(100, 39);
            this.baudRateList.Name = "baudRateList";
            this.baudRateList.Size = new System.Drawing.Size(94, 29);
            this.baudRateList.TabIndex = 8;
            this.baudRateList.Text = "115200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(3, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "StopBits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "DataBits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Com:";
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.connectBtn.Location = new System.Drawing.Point(8, 169);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(182, 31);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // comPortList
            // 
            this.comPortList.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comPortList.FormattingEnabled = true;
            this.comPortList.Location = new System.Drawing.Point(100, 7);
            this.comPortList.Name = "comPortList";
            this.comPortList.Size = new System.Drawing.Size(94, 29);
            this.comPortList.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.sendBtn);
            this.panel2.Controls.Add(this.endText);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(213, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 44);
            this.panel2.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.sendBtn.Location = new System.Drawing.Point(472, 6);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(85, 31);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // endText
            // 
            this.endText.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.endText.FormattingEnabled = true;
            this.endText.Items.AddRange(new object[] {
            "NONE",
            "NL",
            "CR",
            "NL_CR"});
            this.endText.Location = new System.Drawing.Point(373, 8);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(93, 29);
            this.endText.TabIndex = 0;
            this.endText.Text = "NONE";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBox1.Location = new System.Drawing.Point(0, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.richTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(213, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 430);
            this.panel3.TabIndex = 2;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(678, 430);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // containCRC
            // 
            this.containCRC.AutoSize = true;
            this.containCRC.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.containCRC.Location = new System.Drawing.Point(3, 90);
            this.containCRC.Name = "containCRC";
            this.containCRC.Size = new System.Drawing.Size(142, 25);
            this.containCRC.TabIndex = 4;
            this.containCRC.Text = "Contain CRC";
            this.containCRC.UseVisualStyleBackColor = true;
            // 
            // FormCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 474);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCommand";
            this.Text = "FormCommand";
            this.Load += new System.EventHandler(this.FormCommand_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.ComboBox endText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox transferMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox receiveMode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cleanBtn;
        private System.Windows.Forms.CheckBox enableShowSend;
        private System.Windows.Forms.CheckBox enableShowTime;
        private System.Windows.Forms.CheckBox enableAutoScroll;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox stopBitsList;
        private System.Windows.Forms.ComboBox dataBitsList;
        private System.Windows.Forms.ComboBox parityList;
        private System.Windows.Forms.ComboBox baudRateList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox comPortList;
        private System.Windows.Forms.CheckBox containCRC;
    }
}