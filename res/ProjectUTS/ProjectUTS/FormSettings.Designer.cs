namespace ProjectUTS
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.pictureBoxBtnSimpan = new System.Windows.Forms.PictureBox();
            this.textBoxDB = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxCls = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnSimpan)).BeginInit();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBtnSimpan
            // 
            this.pictureBoxBtnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBtnSimpan.Location = new System.Drawing.Point(297, 97);
            this.pictureBoxBtnSimpan.Name = "pictureBoxBtnSimpan";
            this.pictureBoxBtnSimpan.Size = new System.Drawing.Size(88, 27);
            this.pictureBoxBtnSimpan.TabIndex = 3;
            this.pictureBoxBtnSimpan.TabStop = false;
            // 
            // textBoxDB
            // 
            this.textBoxDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDB.Location = new System.Drawing.Point(37, 123);
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Size = new System.Drawing.Size(230, 18);
            this.textBoxDB.TabIndex = 5;
            this.textBoxDB.Text = "Database";
            this.textBoxDB.Enter += new System.EventHandler(this.textBoxDB_Enter);
            this.textBoxDB.Leave += new System.EventHandler(this.textBoxDB_Leave);
            // 
            // textBoxServer
            // 
            this.textBoxServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServer.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxServer.Location = new System.Drawing.Point(37, 83);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(230, 18);
            this.textBoxServer.TabIndex = 4;
            this.textBoxServer.Text = "Server";
            this.textBoxServer.Enter += new System.EventHandler(this.textBoxServer_Enter);
            this.textBoxServer.Leave += new System.EventHandler(this.textBoxServer_Leave);
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.Transparent;
            this.panelBorder.Controls.Add(this.pictureBoxCls);
            this.panelBorder.Controls.Add(this.pictureBoxMin);
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Controls.Add(this.pictureBoxMinimize);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(414, 22);
            this.panelBorder.TabIndex = 6;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // pictureBoxCls
            // 
            this.pictureBoxCls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCls.Location = new System.Drawing.Point(394, 1);
            this.pictureBoxCls.Name = "pictureBoxCls";
            this.pictureBoxCls.Size = new System.Drawing.Size(17, 17);
            this.pictureBoxCls.TabIndex = 8;
            this.pictureBoxCls.TabStop = false;
            this.pictureBoxCls.Click += new System.EventHandler(this.pictureBoxCls_Click);
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMin.Location = new System.Drawing.Point(380, 2);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(15, 16);
            this.pictureBoxMin.TabIndex = 7;
            this.pictureBoxMin.TabStop = false;
            this.pictureBoxMin.Click += new System.EventHandler(this.pictureBoxMin_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Location = new System.Drawing.Point(637, 6);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(17, 18);
            this.pictureBoxClose.TabIndex = 6;
            this.pictureBoxClose.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Location = new System.Drawing.Point(615, 6);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(17, 18);
            this.pictureBoxMinimize.TabIndex = 5;
            this.pictureBoxMinimize.TabStop = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 173);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.textBoxDB);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.pictureBoxBtnSimpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBtnSimpan)).EndInit();
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBtnSimpan;
        private System.Windows.Forms.TextBox textBoxDB;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.PictureBox pictureBoxCls;
    }
}