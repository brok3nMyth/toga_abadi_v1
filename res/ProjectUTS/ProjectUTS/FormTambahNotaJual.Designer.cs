namespace ProjectUTS
{
    partial class FormTambahNotaJual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahNotaJual));
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxNoNota = new System.Windows.Forms.TextBox();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPelanggan = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelKode = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrint = new System.Windows.Forms.PictureBox();
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxBarcode.Location = new System.Drawing.Point(115, 502);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(148, 23);
            this.textBoxBarcode.TabIndex = 11;
            this.textBoxBarcode.Text = "Barcode";
            this.textBoxBarcode.TextChanged += new System.EventHandler(this.textBoxBarcode_TextChanged);
            this.textBoxBarcode.Enter += new System.EventHandler(this.textBoxBarcode_Enter);
            this.textBoxBarcode.Leave += new System.EventHandler(this.textBoxBarcode_Leave);
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJumlah.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxJumlah.Location = new System.Drawing.Point(1052, 500);
            this.textBoxJumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(69, 23);
            this.textBoxJumlah.TabIndex = 12;
            this.textBoxJumlah.Text = "Qty";
            this.textBoxJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxJumlah.Enter += new System.EventHandler(this.textBoxJumlah_Enter);
            this.textBoxJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxJumlah_KeyDown_1);
            this.textBoxJumlah.Leave += new System.EventHandler(this.textBoxJumlah_Leave);
            // 
            // textBoxNoNota
            // 
            this.textBoxNoNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoNota.Enabled = false;
            this.textBoxNoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoNota.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNoNota.Location = new System.Drawing.Point(699, 277);
            this.textBoxNoNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNoNota.Name = "textBoxNoNota";
            this.textBoxNoNota.Size = new System.Drawing.Size(297, 23);
            this.textBoxNoNota.TabIndex = 13;
            this.textBoxNoNota.Text = "Invoice No.";
            this.textBoxNoNota.Enter += new System.EventHandler(this.textBoxNoNota_Enter);
            this.textBoxNoNota.Leave += new System.EventHandler(this.textBoxNoNota_Leave);
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(709, 337);
            this.dateTimePickerTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(285, 22);
            this.dateTimePickerTanggal.TabIndex = 14;
            // 
            // comboBoxPelanggan
            // 
            this.comboBoxPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPelanggan.FormattingEnabled = true;
            this.comboBoxPelanggan.Location = new System.Drawing.Point(351, 278);
            this.comboBoxPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPelanggan.Name = "comboBoxPelanggan";
            this.comboBoxPelanggan.Size = new System.Drawing.Size(183, 24);
            this.comboBoxPelanggan.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(231, 277);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Pelanggan :";
            // 
            // labelKode
            // 
            this.labelKode.BackColor = System.Drawing.Color.Transparent;
            this.labelKode.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKode.Location = new System.Drawing.Point(301, 501);
            this.labelKode.Name = "labelKode";
            this.labelKode.Size = new System.Drawing.Size(92, 25);
            this.labelKode.TabIndex = 26;
            this.labelKode.Text = "Code";
            this.labelKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaBarang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(423, 501);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(303, 25);
            this.labelNamaBarang.TabIndex = 27;
            this.labelNamaBarang.Text = "Item Name";
            this.labelNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHarga
            // 
            this.labelHarga.BackColor = System.Drawing.Color.Transparent;
            this.labelHarga.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(764, 501);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(124, 25);
            this.labelHarga.TabIndex = 28;
            this.labelHarga.Text = "Price";
            this.labelHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSave.Location = new System.Drawing.Point(999, 830);
            this.pictureBoxSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(144, 50);
            this.pictureBoxSave.TabIndex = 36;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.pictureBoxSave_Click);
            // 
            // pictureBoxPrint
            // 
            this.pictureBoxPrint.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPrint.Location = new System.Drawing.Point(829, 830);
            this.pictureBoxPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPrint.Name = "pictureBoxPrint";
            this.pictureBoxPrint.Size = new System.Drawing.Size(144, 50);
            this.pictureBoxPrint.TabIndex = 37;
            this.pictureBoxPrint.TabStop = false;
            this.pictureBoxPrint.Click += new System.EventHandler(this.pictureBoxPrint_Click);
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Location = new System.Drawing.Point(115, 569);
            this.dataGridViewHasil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(997, 226);
            this.dataGridViewHasil.TabIndex = 46;
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.Transparent;
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Controls.Add(this.pictureBoxMinimize);
            this.panelBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(1229, 48);
            this.panelBorder.TabIndex = 47;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Location = new System.Drawing.Point(1187, 11);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1152, 11);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(29, 28);
            this.pictureBoxMinimize.TabIndex = 23;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.labelGrandTotal.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelGrandTotal.Location = new System.Drawing.Point(729, 399);
            this.labelGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(267, 46);
            this.labelGrandTotal.TabIndex = 48;
            this.labelGrandTotal.Text = "0";
            this.labelGrandTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiskon.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDiskon.Location = new System.Drawing.Point(947, 500);
            this.textBoxDiskon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(69, 23);
            this.textBoxDiskon.TabIndex = 49;
            this.textBoxDiskon.Text = "Disc %";
            this.textBoxDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDiskon.Enter += new System.EventHandler(this.textBoxDiskon_Enter);
            this.textBoxDiskon.Leave += new System.EventHandler(this.textBoxDiskon_Leave);
            // 
            // FormTambahNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 896);
            this.Controls.Add(this.textBoxDiskon);
            this.Controls.Add(this.labelGrandTotal);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.pictureBoxPrint);
            this.Controls.Add(this.pictureBoxSave);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelNamaBarang);
            this.Controls.Add(this.labelKode);
            this.Controls.Add(this.comboBoxPelanggan);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.textBoxNoNota);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTambahNotaJual";
            this.Text = "FormTambahNotaJual";
            this.Load += new System.EventHandler(this.FormTambahNotaJual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxNoNota;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.ComboBox comboBoxPelanggan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelKode;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private System.Windows.Forms.PictureBox pictureBoxPrint;
        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.TextBox textBoxDiskon;
    }
}