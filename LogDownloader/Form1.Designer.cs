namespace LogDownloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitBtn = new System.Windows.Forms.Button();
            this.sfLbl = new System.Windows.Forms.Label();
            this.logLbl = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.destLbl = new System.Windows.Forms.Label();
            this.destBox = new System.Windows.Forms.TextBox();
            this.fileBtn = new System.Windows.Forms.Button();
            this.logtypeBox = new System.Windows.Forms.ComboBox();
            this.sfBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // submitBtn
            // 
            this.submitBtn.Enabled = false;
            this.submitBtn.Location = new System.Drawing.Point(431, 70);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(105, 39);
            this.submitBtn.TabIndex = 16;
            this.submitBtn.Text = "Download";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_ClickAsync);
            // 
            // sfLbl
            // 
            this.sfLbl.AutoSize = true;
            this.sfLbl.Location = new System.Drawing.Point(222, 96);
            this.sfLbl.Name = "sfLbl";
            this.sfLbl.Size = new System.Drawing.Size(53, 13);
            this.sfLbl.TabIndex = 3;
            this.sfLbl.Text = "Storefront";
            // 
            // logLbl
            // 
            this.logLbl.AutoSize = true;
            this.logLbl.Location = new System.Drawing.Point(223, 70);
            this.logLbl.Name = "logLbl";
            this.logLbl.Size = new System.Drawing.Size(52, 13);
            this.logLbl.TabIndex = 7;
            this.logLbl.Text = "Log Type";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(68, 8);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(150, 20);
            this.userBox.TabIndex = 0;
            this.userBox.EnabledChanged += new System.EventHandler(this.userBox_EnabledChanged);
            this.userBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(3, 12);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 4;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(228, 12);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Password";
            // 
            // passBox
            // 
            this.passBox.Enabled = false;
            this.passBox.Location = new System.Drawing.Point(291, 8);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(150, 20);
            this.passBox.TabIndex = 1;
            this.passBox.EnabledChanged += new System.EventHandler(this.passBox_EnabledChanged);
            this.passBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // destLbl
            // 
            this.destLbl.AutoSize = true;
            this.destLbl.Location = new System.Drawing.Point(451, 12);
            this.destLbl.Name = "destLbl";
            this.destLbl.Size = new System.Drawing.Size(60, 13);
            this.destLbl.TabIndex = 7;
            this.destLbl.Text = "Destination";
            // 
            // destBox
            // 
            this.destBox.Enabled = false;
            this.destBox.Location = new System.Drawing.Point(521, 8);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(148, 20);
            this.destBox.TabIndex = 1;
            this.destBox.EnabledChanged += new System.EventHandler(this.destBox_EnabledChanged);
            this.destBox.TextChanged += new System.EventHandler(this.destinationBox_TextChanged);
            // 
            // fileBtn
            // 
            this.fileBtn.Enabled = false;
            this.fileBtn.Location = new System.Drawing.Point(679, 7);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(75, 23);
            this.fileBtn.TabIndex = 17;
            this.fileBtn.Text = "Select";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // logtypeBox
            // 
            this.logtypeBox.FormattingEnabled = true;
            this.logtypeBox.Items.AddRange(new object[] {
            "All",
            "Add to Cart",
            "Elastic Path",
            "Elastic Path 1",
            "Elastic Path 2",
            "Services",
            "Services 1",
            "Checkout"});
            this.logtypeBox.Location = new System.Drawing.Point(291, 67);
            this.logtypeBox.Name = "logtypeBox";
            this.logtypeBox.Size = new System.Drawing.Size(121, 21);
            this.logtypeBox.TabIndex = 18;
            this.logtypeBox.SelectedValueChanged += new System.EventHandler(this.logtypeBox_SelectedValueChanged);
            this.logtypeBox.EnabledChanged += new System.EventHandler(this.logtypeBox_EnabledChanged);
            // 
            // sfBox
            // 
            this.sfBox.FormattingEnabled = true;
            this.sfBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.sfBox.Location = new System.Drawing.Point(290, 93);
            this.sfBox.Name = "sfBox";
            this.sfBox.Size = new System.Drawing.Size(121, 21);
            this.sfBox.TabIndex = 19;
            this.sfBox.SelectedValueChanged += new System.EventHandler(this.sfBox_SelectedValueChanged);
            this.sfBox.EnabledChanged += new System.EventHandler(this.sfBox_EnabledChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usernameLbl);
            this.panel1.Controls.Add(this.userBox);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.passwordLbl);
            this.panel1.Controls.Add(this.fileBtn);
            this.panel1.Controls.Add(this.destLbl);
            this.panel1.Controls.Add(this.destBox);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 34);
            this.panel1.TabIndex = 20;
            // 
            // loadingBox
            // 
            this.loadingBox.Image = global::LogDownloader.Properties.Resources.ajax_loader;
            this.loadingBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("loadingBox.InitialImage")));
            this.loadingBox.Location = new System.Drawing.Point(341, 52);
            this.loadingBox.Name = "loadingBox";
            this.loadingBox.Size = new System.Drawing.Size(21, 21);
            this.loadingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingBox.TabIndex = 21;
            this.loadingBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(775, 127);
            this.Controls.Add(this.loadingBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sfLbl);
            this.Controls.Add(this.sfBox);
            this.Controls.Add(this.logtypeBox);
            this.Controls.Add(this.logLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label sfLbl;
        private System.Windows.Forms.Label logLbl;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label destLbl;
        private System.Windows.Forms.TextBox destBox;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.ComboBox logtypeBox;
        private System.Windows.Forms.ComboBox sfBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox loadingBox;
    }
}

