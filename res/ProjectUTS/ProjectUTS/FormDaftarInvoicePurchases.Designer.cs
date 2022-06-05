namespace ProjectUTS
{
    partial class FormDaftarInvoicePurchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarInvoicePurchases));
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxPrint = new System.Windows.Forms.PictureBox();
            this.pictureBoxInsert = new System.Windows.Forms.PictureBox();
            this.pictureBoxSupTelp = new System.Windows.Forms.PictureBox();
            this.pictureBoxSupName = new System.Windows.Forms.PictureBox();
            this.pictureBoxSupCode = new System.Windows.Forms.PictureBox();
            this.pictureBoxTgl = new System.Windows.Forms.PictureBox();
            this.pictureBoxInvNo = new System.Windows.Forms.PictureBox();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupTelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTgl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvNo)).BeginInit();
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
            this.panelBorder.Size = new System.Drawing.Size(1106, 48);
            this.panelBorder.TabIndex = 39;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Location = new System.Drawing.Point(1064, 10);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxClose.TabIndex = 24;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1029, 10);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxMinimize.TabIndex = 23;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHasil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Location = new System.Drawing.Point(81, 315);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(943, 568);
            this.dataGridViewHasil.TabIndex = 38;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearch.Location = new System.Drawing.Point(134, 155);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(730, 31);
            this.textBoxSearch.TabIndex = 34;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // pictureBoxPrint
            // 
            this.pictureBoxPrint.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPrint.Location = new System.Drawing.Point(988, 150);
            this.pictureBoxPrint.Name = "pictureBoxPrint";
            this.pictureBoxPrint.Size = new System.Drawing.Size(46, 44);
            this.pictureBoxPrint.TabIndex = 36;
            this.pictureBoxPrint.TabStop = false;
            this.pictureBoxPrint.Click += new System.EventHandler(this.pictureBoxPrint_Click);
            // 
            // pictureBoxInsert
            // 
            this.pictureBoxInsert.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInsert.Location = new System.Drawing.Point(919, 151);
            this.pictureBoxInsert.Name = "pictureBoxInsert";
            this.pictureBoxInsert.Size = new System.Drawing.Size(46, 44);
            this.pictureBoxInsert.TabIndex = 35;
            this.pictureBoxInsert.TabStop = false;
            this.pictureBoxInsert.Click += new System.EventHandler(this.pictureBoxInsert_Click);
            // 
            // pictureBoxSupTelp
            // 
            this.pictureBoxSupTelp.BackgroundImage = global::ProjectUTS.Properties.Resources.suppliertelp;
            this.pictureBoxSupTelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSupTelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSupTelp.Location = new System.Drawing.Point(818, 229);
            this.pictureBoxSupTelp.Name = "pictureBoxSupTelp";
            this.pictureBoxSupTelp.Size = new System.Drawing.Size(213, 36);
            this.pictureBoxSupTelp.TabIndex = 49;
            this.pictureBoxSupTelp.TabStop = false;
            this.pictureBoxSupTelp.Click += new System.EventHandler(this.pictureBoxSupTelp_Click);
            // 
            // pictureBoxSupName
            // 
            this.pictureBoxSupName.BackgroundImage = global::ProjectUTS.Properties.Resources.suppliername;
            this.pictureBoxSupName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSupName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSupName.Location = new System.Drawing.Point(599, 229);
            this.pictureBoxSupName.Name = "pictureBoxSupName";
            this.pictureBoxSupName.Size = new System.Drawing.Size(213, 36);
            this.pictureBoxSupName.TabIndex = 48;
            this.pictureBoxSupName.TabStop = false;
            this.pictureBoxSupName.Click += new System.EventHandler(this.pictureBoxSupName_Click);
            // 
            // pictureBoxSupCode
            // 
            this.pictureBoxSupCode.BackgroundImage = global::ProjectUTS.Properties.Resources.suppliercode;
            this.pictureBoxSupCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSupCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSupCode.Location = new System.Drawing.Point(380, 229);
            this.pictureBoxSupCode.Name = "pictureBoxSupCode";
            this.pictureBoxSupCode.Size = new System.Drawing.Size(213, 36);
            this.pictureBoxSupCode.TabIndex = 47;
            this.pictureBoxSupCode.TabStop = false;
            this.pictureBoxSupCode.Click += new System.EventHandler(this.pictureBoxSupCode_Click);
            // 
            // pictureBoxTgl
            // 
            this.pictureBoxTgl.BackgroundImage = global::ProjectUTS.Properties.Resources.date;
            this.pictureBoxTgl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTgl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTgl.Location = new System.Drawing.Point(281, 229);
            this.pictureBoxTgl.Name = "pictureBoxTgl";
            this.pictureBoxTgl.Size = new System.Drawing.Size(93, 36);
            this.pictureBoxTgl.TabIndex = 46;
            this.pictureBoxTgl.TabStop = false;
            this.pictureBoxTgl.Click += new System.EventHandler(this.pictureBoxTgl_Click);
            // 
            // pictureBoxInvNo
            // 
            this.pictureBoxInvNo.BackgroundImage = global::ProjectUTS.Properties.Resources.invoiceno_selected;
            this.pictureBoxInvNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxInvNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInvNo.Location = new System.Drawing.Point(88, 229);
            this.pictureBoxInvNo.Name = "pictureBoxInvNo";
            this.pictureBoxInvNo.Size = new System.Drawing.Size(187, 36);
            this.pictureBoxInvNo.TabIndex = 45;
            this.pictureBoxInvNo.TabStop = false;
            this.pictureBoxInvNo.Click += new System.EventHandler(this.pictureBoxInvNo_Click);
            // 
            // FormDaftarInvoicePurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 892);
            this.Controls.Add(this.pictureBoxSupTelp);
            this.Controls.Add(this.pictureBoxSupName);
            this.Controls.Add(this.pictureBoxSupCode);
            this.Controls.Add(this.pictureBoxTgl);
            this.Controls.Add(this.pictureBoxInvNo);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBoxPrint);
            this.Controls.Add(this.pictureBoxInsert);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarInvoicePurchases";
            this.Text = "FormDaftarInvoicePurchases";
            this.Load += new System.EventHandler(this.FormDaftarInvoicePurchases_Load);
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupTelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTgl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxPrint;
        private System.Windows.Forms.PictureBox pictureBoxInsert;
        private System.Windows.Forms.PictureBox pictureBoxSupTelp;
        private System.Windows.Forms.PictureBox pictureBoxSupName;
        private System.Windows.Forms.PictureBox pictureBoxSupCode;
        private System.Windows.Forms.PictureBox pictureBoxTgl;
        private System.Windows.Forms.PictureBox pictureBoxInvNo;
    }
}