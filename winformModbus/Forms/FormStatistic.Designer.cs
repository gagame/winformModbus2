namespace winformModbus.Forms
{
    partial class FormStatistic
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.pollTextBox = new System.Windows.Forms.TextBox();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.parityTextBox = new System.Windows.Forms.TextBox();
            this.stopbitsTextBox = new System.Windows.Forms.TextBox();
            this.databitsTextBox = new System.Windows.Forms.TextBox();
            this.baudTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchListbox = new System.Windows.Forms.ListBox();
            this.comTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.cartesianChart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 492);
            this.panel1.TabIndex = 0;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(23, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(976, 263);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.panel2.Controls.Add(this.responseTextBox);
            this.panel2.Controls.Add(this.pollTextBox);
            this.panel2.Controls.Add(this.functionTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.addressTextBox);
            this.panel2.Controls.Add(this.parityTextBox);
            this.panel2.Controls.Add(this.stopbitsTextBox);
            this.panel2.Controls.Add(this.databitsTextBox);
            this.panel2.Controls.Add(this.baudTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.insertBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchListbox);
            this.panel2.Controls.Add(this.comTextBox);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 200);
            this.panel2.TabIndex = 1;
            // 
            // responseTextBox
            // 
            this.responseTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.responseTextBox.Location = new System.Drawing.Point(430, 125);
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.Size = new System.Drawing.Size(100, 28);
            this.responseTextBox.TabIndex = 22;
            // 
            // pollTextBox
            // 
            this.pollTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.pollTextBox.Location = new System.Drawing.Point(430, 87);
            this.pollTextBox.Name = "pollTextBox";
            this.pollTextBox.Size = new System.Drawing.Size(100, 28);
            this.pollTextBox.TabIndex = 21;
            // 
            // functionTextBox
            // 
            this.functionTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.functionTextBox.Location = new System.Drawing.Point(430, 49);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(100, 28);
            this.functionTextBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(333, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Response:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(333, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Poll:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(333, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Function:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(333, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.addressTextBox.Location = new System.Drawing.Point(430, 11);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 28);
            this.addressTextBox.TabIndex = 15;
            // 
            // parityTextBox
            // 
            this.parityTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.parityTextBox.Location = new System.Drawing.Point(214, 163);
            this.parityTextBox.Name = "parityTextBox";
            this.parityTextBox.Size = new System.Drawing.Size(100, 28);
            this.parityTextBox.TabIndex = 14;
            // 
            // stopbitsTextBox
            // 
            this.stopbitsTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.stopbitsTextBox.Location = new System.Drawing.Point(214, 125);
            this.stopbitsTextBox.Name = "stopbitsTextBox";
            this.stopbitsTextBox.Size = new System.Drawing.Size(100, 28);
            this.stopbitsTextBox.TabIndex = 13;
            // 
            // databitsTextBox
            // 
            this.databitsTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.databitsTextBox.Location = new System.Drawing.Point(214, 87);
            this.databitsTextBox.Name = "databitsTextBox";
            this.databitsTextBox.Size = new System.Drawing.Size(100, 28);
            this.databitsTextBox.TabIndex = 12;
            // 
            // baudTextBox
            // 
            this.baudTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.baudTextBox.Location = new System.Drawing.Point(214, 49);
            this.baudTextBox.Name = "baudTextBox";
            this.baudTextBox.Size = new System.Drawing.Size(100, 28);
            this.baudTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(129, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(129, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "StopBits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(129, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "DataBits:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(129, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud:";
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.insertBtn.Location = new System.Drawing.Point(23, 53);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(87, 33);
            this.insertBtn.TabIndex = 6;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(129, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM:";
            // 
            // searchListbox
            // 
            this.searchListbox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.searchListbox.FormattingEnabled = true;
            this.searchListbox.ItemHeight = 21;
            this.searchListbox.Location = new System.Drawing.Point(555, 23);
            this.searchListbox.Name = "searchListbox";
            this.searchListbox.Size = new System.Drawing.Size(444, 151);
            this.searchListbox.TabIndex = 4;
            // 
            // comTextBox
            // 
            this.comTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comTextBox.Location = new System.Drawing.Point(214, 11);
            this.comTextBox.Name = "comTextBox";
            this.comTextBox.Size = new System.Drawing.Size(100, 28);
            this.comTextBox.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.searchBtn.Location = new System.Drawing.Point(23, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(87, 33);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.clearBtn.Location = new System.Drawing.Point(23, 92);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(87, 33);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormStatistic";
            this.Text = "FormStatistic";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baudrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pollCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox comTextBox;
        private System.Windows.Forms.ListBox searchListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.TextBox pollTextBox;
        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox parityTextBox;
        private System.Windows.Forms.TextBox stopbitsTextBox;
        private System.Windows.Forms.TextBox databitsTextBox;
        private System.Windows.Forms.TextBox baudTextBox;
        private System.Windows.Forms.Label label5;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}