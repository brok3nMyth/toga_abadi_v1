
namespace kerjapraktik
{
    partial class FormInputArtikelPotong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKodeArtikel = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.seri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yard_kain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeXL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTambahBagian = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARTIKEL POTONG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARTIKEL : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BRAND   : ";
            // 
            // textBoxKodeArtikel
            // 
            this.textBoxKodeArtikel.Location = new System.Drawing.Point(68, 56);
            this.textBoxKodeArtikel.Multiline = true;
            this.textBoxKodeArtikel.Name = "textBoxKodeArtikel";
            this.textBoxKodeArtikel.Size = new System.Drawing.Size(99, 28);
            this.textBoxKodeArtikel.TabIndex = 29;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(68, 95);
            this.textBoxBrand.Multiline = true;
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(99, 28);
            this.textBoxBrand.TabIndex = 30;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seri,
            this.yard_kain,
            this.sizeM,
            this.sizeL,
            this.sizeXL,
            this.jumlah});
            this.dataGridViewData.Location = new System.Drawing.Point(14, 151);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(736, 274);
            this.dataGridViewData.TabIndex = 31;
            // 
            // seri
            // 
            this.seri.HeaderText = "Seri";
            this.seri.Name = "seri";
            // 
            // yard_kain
            // 
            this.yard_kain.HeaderText = "Yard Kain";
            this.yard_kain.Name = "yard_kain";
            // 
            // sizeM
            // 
            this.sizeM.HeaderText = "Size M";
            this.sizeM.Name = "sizeM";
            // 
            // sizeL
            // 
            this.sizeL.HeaderText = "Size L";
            this.sizeL.Name = "sizeL";
            // 
            // sizeXL
            // 
            this.sizeXL.HeaderText = "Size XL";
            this.sizeXL.Name = "sizeXL";
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(651, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 28);
            this.textBox1.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "KAIN : ";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(651, 442);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(99, 28);
            this.textBoxTotal.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "TOTAL : ";
            // 
            // buttonTambahBagian
            // 
            this.buttonTambahBagian.Location = new System.Drawing.Point(14, 440);
            this.buttonTambahBagian.Name = "buttonTambahBagian";
            this.buttonTambahBagian.Size = new System.Drawing.Size(134, 30);
            this.buttonTambahBagian.TabIndex = 36;
            this.buttonTambahBagian.Text = "Tambah Bagian";
            this.buttonTambahBagian.UseVisualStyleBackColor = true;
            this.buttonTambahBagian.Click += new System.EventHandler(this.buttonTambahBagian_Click);
            // 
            // FormInputArtikelPotong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 485);
            this.Controls.Add(this.buttonTambahBagian);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxKodeArtikel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInputArtikelPotong";
            this.Text = "Input Artikel Potong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKodeArtikel;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn seri;
        private System.Windows.Forms.DataGridViewTextBoxColumn yard_kain;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeL;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeXL;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTambahBagian;
    }
}