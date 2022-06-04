
namespace kerjapraktik
{
    partial class FormUbahGaji
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
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.art = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bagian = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonCari = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.buttonTambahBagian = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxBagian = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewDataBagian = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxArt = new System.Windows.Forms.TextBox();
            this.buttonKunciGaji = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonUBAH = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalGajian = new System.Windows.Forms.DateTimePicker();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTempat = new System.Windows.Forms.TextBox();
            this.totalan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBagian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // no
            // 
            this.no.HeaderText = "NO";
            this.no.Name = "no";
            // 
            // art
            // 
            this.art.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.art.HeaderText = "ARTIKEL-SERI-SIZE";
            this.art.Name = "art";
            // 
            // jumlah
            // 
            this.jumlah.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.jumlah.HeaderText = "JUMLAH";
            this.jumlah.Name = "jumlah";
            // 
            // bagian
            // 
            this.bagian.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.bagian.HeaderText = "BAGIAN";
            this.bagian.Name = "bagian";
            // 
            // harga
            // 
            this.harga.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.harga.HeaderText = "HARGA";
            this.harga.Name = "harga";
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Linen;
            this.buttonCari.Location = new System.Drawing.Point(392, 203);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(99, 29);
            this.buttonCari.TabIndex = 163;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 161;
            this.label12.Text = "JUMLAH :";
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(99, 265);
            this.textBoxJumlah.Multiline = true;
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(143, 28);
            this.textBoxJumlah.TabIndex = 160;
            // 
            // buttonTambahBagian
            // 
            this.buttonTambahBagian.Location = new System.Drawing.Point(392, 264);
            this.buttonTambahBagian.Name = "buttonTambahBagian";
            this.buttonTambahBagian.Size = new System.Drawing.Size(99, 32);
            this.buttonTambahBagian.TabIndex = 158;
            this.buttonTambahBagian.Text = "Tambah Bagian";
            this.buttonTambahBagian.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 157;
            this.label13.Text = "BAGIAN :";
            // 
            // comboBoxBagian
            // 
            this.comboBoxBagian.FormattingEnabled = true;
            this.comboBoxBagian.Items.AddRange(new object[] {
            "Gosok krah",
            "",
            "Krah ",
            "",
            "Badan (include badan depan, belakang, skaur, jahit tangan) ",
            "",
            "Roges",
            "",
            "Obras tangan",
            "",
            "Tindes tangan",
            "",
            "Make up",
            "",
            "Lipat bawah",
            "",
            "Naskat",
            "",
            "Kancing",
            "",
            "Bersih benang",
            "",
            "Gosok"});
            this.comboBoxBagian.Location = new System.Drawing.Point(100, 238);
            this.comboBoxBagian.Name = "comboBoxBagian";
            this.comboBoxBagian.Size = new System.Drawing.Size(276, 21);
            this.comboBoxBagian.TabIndex = 156;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(202, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 162;
            this.label14.Text = "DATA BAGIAN";
            // 
            // dataGridViewDataBagian
            // 
            this.dataGridViewDataBagian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBagian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColumnJumlah,
            this.Biaya});
            this.dataGridViewDataBagian.Location = new System.Drawing.Point(19, 338);
            this.dataGridViewDataBagian.Name = "dataGridViewDataBagian";
            this.dataGridViewDataBagian.Size = new System.Drawing.Size(357, 191);
            this.dataGridViewDataBagian.TabIndex = 159;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ColumnBagian";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ColumnJumlah
            // 
            this.ColumnJumlah.HeaderText = "ColumnJumlah";
            this.ColumnJumlah.Name = "ColumnJumlah";
            // 
            // Biaya
            // 
            this.Biaya.HeaderText = "ColumnBiaya";
            this.Biaya.Name = "Biaya";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 155;
            this.label11.Text = "NO ARTIKEL :";
            // 
            // textBoxArt
            // 
            this.textBoxArt.Location = new System.Drawing.Point(99, 204);
            this.textBoxArt.Multiline = true;
            this.textBoxArt.Name = "textBoxArt";
            this.textBoxArt.Size = new System.Drawing.Size(277, 28);
            this.textBoxArt.TabIndex = 154;
            // 
            // buttonKunciGaji
            // 
            this.buttonKunciGaji.Location = new System.Drawing.Point(390, 135);
            this.buttonKunciGaji.Name = "buttonKunciGaji";
            this.buttonKunciGaji.Size = new System.Drawing.Size(101, 37);
            this.buttonKunciGaji.TabIndex = 153;
            this.buttonKunciGaji.Text = "Kunci Gaji";
            this.buttonKunciGaji.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(331, 13);
            this.label10.TabIndex = 152;
            this.label10.Text = "---------------------------------------------------------------------------------" +
    "---------------------------";
            // 
            // buttonUBAH
            // 
            this.buttonUBAH.Location = new System.Drawing.Point(1031, 498);
            this.buttonUBAH.Name = "buttonUBAH";
            this.buttonUBAH.Size = new System.Drawing.Size(131, 31);
            this.buttonUBAH.TabIndex = 151;
            this.buttonUBAH.Text = "UBAH";
            this.buttonUBAH.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Location = new System.Drawing.Point(627, 500);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 28);
            this.textBox3.TabIndex = 150;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(627, 466);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 28);
            this.textBox2.TabIndex = 148;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 147;
            this.label8.Text = "POTONG BON : ";
            // 
            // dateTimePickerTanggalGajian
            // 
            this.dateTimePickerTanggalGajian.Location = new System.Drawing.Point(130, 141);
            this.dateTimePickerTanggalGajian.Name = "dateTimePickerTanggalGajian";
            this.dateTimePickerTanggalGajian.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerTanggalGajian.TabIndex = 140;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(88, 62);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(277, 28);
            this.textBoxNama.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 136;
            this.label3.Text = "TEMPAT   : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 135;
            this.label2.Text = "NAMA : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 134;
            this.label1.Text = "FORM UBAH GAJI";
            // 
            // textBoxTempat
            // 
            this.textBoxTempat.Location = new System.Drawing.Point(88, 104);
            this.textBoxTempat.Multiline = true;
            this.textBoxTempat.Name = "textBoxTempat";
            this.textBoxTempat.Size = new System.Drawing.Size(277, 28);
            this.textBoxTempat.TabIndex = 138;
            // 
            // totalan
            // 
            this.totalan.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.totalan.HeaderText = "TOTALAN";
            this.totalan.Name = "totalan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(627, 432);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 28);
            this.textBox1.TabIndex = 146;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 145;
            this.label7.Text = "SISA BON : ";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(627, 398);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(177, 28);
            this.textBoxTotal.TabIndex = 144;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 143;
            this.label6.Text = "SUBTOTAL : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(835, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 13);
            this.label5.TabIndex = 142;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "---------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(565, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 149;
            this.label9.Text = "TOTAL : ";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.art,
            this.jumlah,
            this.bagian,
            this.harga,
            this.totalan});
            this.dataGridViewData.Location = new System.Drawing.Point(519, 62);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(643, 317);
            this.dataGridViewData.TabIndex = 141;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 139;
            this.label4.Text = "TANGGAL GAJIAN : ";
            // 
            // FormUbahGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 557);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.buttonTambahBagian);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxBagian);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridViewDataBagian);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxArt);
            this.Controls.Add(this.buttonKunciGaji);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonUBAH);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerTanggalGajian);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTempat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.label4);
            this.Name = "FormUbahGaji";
            this.Text = "Form Ubah Gaji";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBagian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewComboBoxColumn art;
        private System.Windows.Forms.DataGridViewComboBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewComboBoxColumn bagian;
        private System.Windows.Forms.DataGridViewComboBoxColumn harga;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Button buttonTambahBagian;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxBagian;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewDataBagian;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biaya;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxArt;
        private System.Windows.Forms.Button buttonKunciGaji;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonUBAH;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalGajian;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTempat;
        private System.Windows.Forms.DataGridViewComboBoxColumn totalan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label label4;
    }
}