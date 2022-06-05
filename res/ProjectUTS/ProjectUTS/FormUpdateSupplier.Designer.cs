namespace ProjectUTS
{
    partial class FormUpdateSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateSupplier));
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.pictureBoxOk = new System.Windows.Forms.PictureBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.Transparent;
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Controls.Add(this.pictureBoxMinimize);
            this.panelBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(550, 34);
            this.panelBorder.TabIndex = 52;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Location = new System.Drawing.Point(522, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(23, 24);
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(499, 5);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(23, 24);
            this.pictureBoxMinimize.TabIndex = 1;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTelephone.Location = new System.Drawing.Point(118, 367);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(316, 23);
            this.textBoxTelephone.TabIndex = 56;
            this.textBoxTelephone.Text = "Telephone";
            this.textBoxTelephone.TextChanged += new System.EventHandler(this.textBoxTelephone_TextChanged);
            this.textBoxTelephone.Enter += new System.EventHandler(this.textBoxTelephone_Enter);
            this.textBoxTelephone.Leave += new System.EventHandler(this.textBoxTelephone_Leave);
            // 
            // pictureBoxOk
            // 
            this.pictureBoxOk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOk.Location = new System.Drawing.Point(369, 592);
            this.pictureBoxOk.Name = "pictureBoxOk";
            this.pictureBoxOk.Size = new System.Drawing.Size(146, 51);
            this.pictureBoxOk.TabIndex = 55;
            this.pictureBoxOk.TabStop = false;
            this.pictureBoxOk.Click += new System.EventHandler(this.pictureBoxOk_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNama.Location = new System.Drawing.Point(118, 288);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(316, 23);
            this.textBoxNama.TabIndex = 54;
            this.textBoxNama.Text = "Name";
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            this.textBoxNama.Enter += new System.EventHandler(this.textBoxNama_Enter);
            this.textBoxNama.Leave += new System.EventHandler(this.textBoxNama_Leave);
            // 
            // textBoxKode
            // 
            this.textBoxKode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKode.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxKode.Location = new System.Drawing.Point(118, 209);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(316, 23);
            this.textBoxKode.TabIndex = 53;
            this.textBoxKode.Text = "Code";
            this.textBoxKode.TextChanged += new System.EventHandler(this.textBoxKode_TextChanged);
            this.textBoxKode.Enter += new System.EventHandler(this.textBoxKode_Enter);
            this.textBoxKode.Leave += new System.EventHandler(this.textBoxKode_Leave);
            // 
            // FormUpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 678);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.pictureBoxOk);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxKode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdateSupplier";
            this.Text = "FormUpdateSupplier";
            this.Load += new System.EventHandler(this.FormUpdateSupplier_Load);
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.PictureBox pictureBoxOk;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxKode;
    }
}