namespace ProjectUTS
{
    partial class FormDeleteBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteBarang));
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxOk = new System.Windows.Forms.PictureBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxHmeter = new System.Windows.Forms.TextBox();
            this.textBoxHRoll = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.textBoxDiameter = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
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
            this.panelBorder.TabIndex = 23;
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
            // pictureBoxOk
            // 
            this.pictureBoxOk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOk.Location = new System.Drawing.Point(366, 660);
            this.pictureBoxOk.Name = "pictureBoxOk";
            this.pictureBoxOk.Size = new System.Drawing.Size(146, 51);
            this.pictureBoxOk.TabIndex = 29;
            this.pictureBoxOk.TabStop = false;
            this.pictureBoxOk.Click += new System.EventHandler(this.pictureBoxOk_Click);
            // 
            // textBoxStock
            // 
            this.textBoxStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStock.Enabled = false;
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxStock.Location = new System.Drawing.Point(116, 539);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(316, 23);
            this.textBoxStock.TabIndex = 28;
            this.textBoxStock.Text = "Stock";
            this.textBoxStock.Enter += new System.EventHandler(this.textBoxStock_Enter);
            this.textBoxStock.Leave += new System.EventHandler(this.textBoxStock_Leave);
            // 
            // textBoxHmeter
            // 
            this.textBoxHmeter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHmeter.Enabled = false;
            this.textBoxHmeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHmeter.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxHmeter.Location = new System.Drawing.Point(116, 473);
            this.textBoxHmeter.Name = "textBoxHmeter";
            this.textBoxHmeter.Size = new System.Drawing.Size(316, 23);
            this.textBoxHmeter.TabIndex = 27;
            this.textBoxHmeter.Text = "Price/M";
            this.textBoxHmeter.Enter += new System.EventHandler(this.textBoxHmeter_Enter);
            this.textBoxHmeter.Leave += new System.EventHandler(this.textBoxHmeter_Leave);
            // 
            // textBoxHRoll
            // 
            this.textBoxHRoll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHRoll.Enabled = false;
            this.textBoxHRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHRoll.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxHRoll.Location = new System.Drawing.Point(116, 407);
            this.textBoxHRoll.Name = "textBoxHRoll";
            this.textBoxHRoll.Size = new System.Drawing.Size(316, 23);
            this.textBoxHRoll.TabIndex = 26;
            this.textBoxHRoll.Text = "Price/Roll";
            this.textBoxHRoll.Enter += new System.EventHandler(this.textBoxHRoll_Enter);
            this.textBoxHRoll.Leave += new System.EventHandler(this.textBoxHRoll_Leave);
            // 
            // textBoxNama
            // 
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Enabled = false;
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNama.Location = new System.Drawing.Point(116, 343);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(316, 23);
            this.textBoxNama.TabIndex = 25;
            this.textBoxNama.Text = "Name";
            this.textBoxNama.Enter += new System.EventHandler(this.textBoxNama_Enter);
            this.textBoxNama.Leave += new System.EventHandler(this.textBoxNama_Leave);
            // 
            // textBoxKode
            // 
            this.textBoxKode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKode.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxKode.Location = new System.Drawing.Point(116, 210);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(316, 23);
            this.textBoxKode.TabIndex = 24;
            this.textBoxKode.Text = "Code";
            this.textBoxKode.TextChanged += new System.EventHandler(this.textBoxKode_TextChanged);
            this.textBoxKode.Enter += new System.EventHandler(this.textBoxKode_Enter);
            this.textBoxKode.Leave += new System.EventHandler(this.textBoxKode_Leave);
            // 
            // textBoxDiameter
            // 
            this.textBoxDiameter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiameter.Enabled = false;
            this.textBoxDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiameter.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDiameter.Location = new System.Drawing.Point(116, 605);
            this.textBoxDiameter.Name = "textBoxDiameter";
            this.textBoxDiameter.Size = new System.Drawing.Size(316, 23);
            this.textBoxDiameter.TabIndex = 30;
            this.textBoxDiameter.Text = "Diameter";
            this.textBoxDiameter.Enter += new System.EventHandler(this.textBoxDiameter_Enter);
            this.textBoxDiameter.Leave += new System.EventHandler(this.textBoxDiameter_Leave);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCategory.Enabled = false;
            this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategory.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCategory.Location = new System.Drawing.Point(116, 273);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(316, 23);
            this.textBoxCategory.TabIndex = 31;
            this.textBoxCategory.Text = "Category ";
            // 
            // FormDeleteBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 754);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxDiameter);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.pictureBoxOk);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxHmeter);
            this.Controls.Add(this.textBoxHRoll);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxKode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeleteBarang";
            this.Text = "FormHapusBarang";
            this.Load += new System.EventHandler(this.FormDeleteBarang_Load);
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
        private System.Windows.Forms.PictureBox pictureBoxOk;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxHmeter;
        private System.Windows.Forms.TextBox textBoxHRoll;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.TextBox textBoxDiameter;
        private System.Windows.Forms.TextBox textBoxCategory;
    }
}