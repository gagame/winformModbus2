namespace winformModbus
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.StatisticBtn = new FontAwesome.Sharp.IconButton();
            this.CommandBtn = new FontAwesome.Sharp.IconButton();
            this.PortsScanBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.maximizeBtn = new FontAwesome.Sharp.IconButton();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.StatisticBtn);
            this.panelMenu.Controls.Add(this.CommandBtn);
            this.panelMenu.Controls.Add(this.PortsScanBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(256, 532);
            this.panelMenu.TabIndex = 0;
            // 
            // StatisticBtn
            // 
            this.StatisticBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatisticBtn.FlatAppearance.BorderSize = 0;
            this.StatisticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticBtn.ForeColor = System.Drawing.Color.Lavender;
            this.StatisticBtn.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.StatisticBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.StatisticBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StatisticBtn.IconSize = 36;
            this.StatisticBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticBtn.Location = new System.Drawing.Point(0, 240);
            this.StatisticBtn.Name = "StatisticBtn";
            this.StatisticBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.StatisticBtn.Size = new System.Drawing.Size(256, 70);
            this.StatisticBtn.TabIndex = 3;
            this.StatisticBtn.Text = "Statistic";
            this.StatisticBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StatisticBtn.UseVisualStyleBackColor = true;
            this.StatisticBtn.Click += new System.EventHandler(this.StatisticBtn_Click);
            // 
            // CommandBtn
            // 
            this.CommandBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommandBtn.FlatAppearance.BorderSize = 0;
            this.CommandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandBtn.ForeColor = System.Drawing.Color.Lavender;
            this.CommandBtn.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.CommandBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CommandBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CommandBtn.IconSize = 36;
            this.CommandBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommandBtn.Location = new System.Drawing.Point(0, 170);
            this.CommandBtn.Name = "CommandBtn";
            this.CommandBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.CommandBtn.Size = new System.Drawing.Size(256, 70);
            this.CommandBtn.TabIndex = 2;
            this.CommandBtn.Text = "Command";
            this.CommandBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommandBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CommandBtn.UseVisualStyleBackColor = true;
            this.CommandBtn.Click += new System.EventHandler(this.CommandBtn_Click);
            // 
            // PortsScanBtn
            // 
            this.PortsScanBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PortsScanBtn.FlatAppearance.BorderSize = 0;
            this.PortsScanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortsScanBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortsScanBtn.ForeColor = System.Drawing.Color.Lavender;
            this.PortsScanBtn.IconChar = FontAwesome.Sharp.IconChar.Usb;
            this.PortsScanBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.PortsScanBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PortsScanBtn.IconSize = 36;
            this.PortsScanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PortsScanBtn.Location = new System.Drawing.Point(0, 100);
            this.PortsScanBtn.Name = "PortsScanBtn";
            this.PortsScanBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PortsScanBtn.Size = new System.Drawing.Size(256, 70);
            this.PortsScanBtn.TabIndex = 1;
            this.PortsScanBtn.Text = "PortsScan";
            this.PortsScanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PortsScanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PortsScanBtn.UseVisualStyleBackColor = true;
            this.PortsScanBtn.Click += new System.EventHandler(this.PortsScanBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.HomeBtn);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(256, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.Location = new System.Drawing.Point(12, 12);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(166, 73);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitleBar.Controls.Add(this.maximizeBtn);
            this.panelTitleBar.Controls.Add(this.minimizeBtn);
            this.panelTitleBar.Controls.Add(this.exitBtn);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(256, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1037, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.FlatAppearance.BorderSize = 0;
            this.maximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximizeBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.maximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximizeBtn.IconSize = 24;
            this.maximizeBtn.Location = new System.Drawing.Point(968, 2);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Size = new System.Drawing.Size(34, 23);
            this.maximizeBtn.TabIndex = 4;
            this.maximizeBtn.UseVisualStyleBackColor = true;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 24;
            this.minimizeBtn.Location = new System.Drawing.Point(933, 2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(34, 23);
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.exitBtn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 24;
            this.exitBtn.Location = new System.Drawing.Point(1003, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(34, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Lavender;
            this.labelTitleChildForm.Location = new System.Drawing.Point(54, 20);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(59, 21);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Lavender;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Lavender;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 15);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(256, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1037, 7);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(256, 67);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1037, 465);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 532);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton StatisticBtn;
        private FontAwesome.Sharp.IconButton CommandBtn;
        private FontAwesome.Sharp.IconButton PortsScanBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox HomeBtn;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton maximizeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
    }
}

