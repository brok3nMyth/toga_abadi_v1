namespace ProjectUTS
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxBtnLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelBorderSettings = new System.Windows.Forms.Panel();
            this.pictureBoxCls = new System.Windows.Forms.PictureBox();
            this.textBoxDB = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.pictureBoxBtnSimpan = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelBorderSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnSimpan)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxUsername.Location = new System.Drawing.Point(155, 254);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(230, 18);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPassword.Location = new System.Drawing.Point(155, 296);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(230, 18);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // pictureBoxBtnLogin
            // 
            this.pictureBoxBtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBtnLogin.Location = new System.Drawing.Point(420, 263);
            this.pictureBoxBtnLogin.Name = "pictureBoxBtnLogin";
            this.pictureBoxBtnLogin.Size = new System.Drawing.Size(92, 36);
            this.pictureBoxBtnLogin.TabIndex = 2;
            this.pictureBoxBtnLogin.TabStop = false;
            this.pictureBoxBtnLogin.Click += new System.EventHandler(this.pictureBoxBtnLogin_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Location = new System.Drawing.Point(12, 431);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(117, 23);
            this.pictureBoxSettings.TabIndex = 3;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSettings.BackgroundImage")));
            this.panelSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSettings.Controls.Add(this.panelBorderSettings);
            this.panelSettings.Controls.Add(this.textBoxDB);
            this.panelSettings.Controls.Add(this.textBoxServer);
            this.panelSettings.Controls.Add(this.pictureBoxBtnSimpan);
            this.panelSettings.Location = new System.Drawing.Point(1, 461);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(661, 300);
            this.panelSettings.TabIndex = 1;
            // 
            // panelBorderSettings
            // 
            this.panelBorderSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelBorderSettings.Controls.Add(this.pictureBoxCls);
            this.panelBorderSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorderSettings.Location = new System.Drawing.Point(0, 0);
            this.panelBorderSettings.Name = "panelBorderSettings";
            this.panelBorderSettings.Size = new System.Drawing.Size(661, 31);
            this.panelBorderSettings.TabIndex = 0;
            // 
            // pictureBoxCls
            // 
            this.pictureBoxCls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCls.Location = new System.Drawing.Point(634, 4);
            this.pictureBoxCls.Name = "pictureBoxCls";
            this.pictureBoxCls.Size = new System.Drawing.Size(20, 24);
            this.pictureBoxCls.TabIndex = 8;
            this.pictureBoxCls.TabStop = false;
            this.pictureBoxCls.Click += new System.EventHandler(this.pictureBoxCls_Click);
            // 
            // textBoxDB
            // 
            this.textBoxDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDB.ForeColor = System.Drawing.Color.Black;
            this.textBoxDB.Location = new System.Drawing.Point(66, 216);
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Size = new System.Drawing.Size(230, 23);
            this.textBoxDB.TabIndex = 1;
            this.textBoxDB.Text = "Database";
            // 
            // textBoxServer
            // 
            this.textBoxServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServer.ForeColor = System.Drawing.Color.Black;
            this.textBoxServer.Location = new System.Drawing.Point(66, 151);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(230, 23);
            this.textBoxServer.TabIndex = 0;
            this.textBoxServer.Text = "Server";
            // 
            // pictureBoxBtnSimpan
            // 
            this.pictureBoxBtnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBtnSimpan.Location = new System.Drawing.Point(472, 168);
            this.pictureBoxBtnSimpan.Name = "pictureBoxBtnSimpan";
            this.pictureBoxBtnSimpan.Size = new System.Drawing.Size(143, 46);
            this.pictureBoxBtnSimpan.TabIndex = 7;
            this.pictureBoxBtnSimpan.TabStop = false;
            this.pictureBoxBtnSimpan.Click += new System.EventHandler(this.pictureBoxBtnSimpan_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogin.BackgroundImage")));
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogin.Controls.Add(this.panelBorder);
            this.panelLogin.Controls.Add(this.pictureBoxBtnLogin);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.pictureBoxSettings);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(662, 459);
            this.panelLogin.TabIndex = 1;
            // 
            // panelBorder
            // 
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Controls.Add(this.pictureBoxMinimize);
            this.panelBorder.Location = new System.Drawing.Point(1, 1);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(660, 28);
            this.panelBorder.TabIndex = 0;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown_1);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Location = new System.Drawing.Point(634, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(20, 19);
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click_1);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Location = new System.Drawing.Point(612, 5);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(20, 19);
            this.pictureBoxMinimize.TabIndex = 1;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 760);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelBorderSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnSimpan)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxBtnLogin;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelBorderSettings;
        private System.Windows.Forms.PictureBox pictureBoxCls;
        private System.Windows.Forms.TextBox textBoxDB;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.PictureBox pictureBoxBtnSimpan;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
    }
}