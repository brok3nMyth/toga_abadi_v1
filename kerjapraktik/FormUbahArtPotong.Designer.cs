
namespace kerjapraktik
{
    partial class FormUbahArtPotong
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
            this.buttonUbahBagian = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxKain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeXL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.sizeM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.yard_kain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxArtikel = new System.Windows.Forms.ComboBox();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.textBoxXL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxYard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSeri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUbahBagian
            // 
            this.buttonUbahBagian.Location = new System.Drawing.Point(25, 514);
            this.buttonUbahBagian.Name = "buttonUbahBagian";
            this.buttonUbahBagian.Size = new System.Drawing.Size(134, 30);
            this.buttonUbahBagian.TabIndex = 47;
            this.buttonUbahBagian.Text = "Ubah Bagian";
            this.buttonUbahBagian.UseVisualStyleBackColor = true;
            this.buttonUbahBagian.Click += new System.EventHandler(this.buttonUbahBagian_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(662, 516);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(99, 28);
            this.textBoxTotal.TabIndex = 46;
            // 
            // textBoxKain
            // 
            this.textBoxKain.Location = new System.Drawing.Point(662, 60);
            this.textBoxKain.Multiline = true;
            this.textBoxKain.Name = "textBoxKain";
            this.textBoxKain.Size = new System.Drawing.Size(99, 28);
            this.textBoxKain.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "KAIN : ";
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            // 
            // sizeXL
            // 
            this.sizeXL.HeaderText = "Size XL";
            this.sizeXL.Name = "sizeXL";
            // 
            // sizeL
            // 
            this.sizeL.HeaderText = "Size L";
            this.sizeL.Name = "sizeL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "TOTAL : ";
            // 
            // sizeM
            // 
            this.sizeM.HeaderText = "Size M";
            this.sizeM.Name = "sizeM";
            // 
            // seri
            // 
            this.seri.HeaderText = "Seri";
            this.seri.Name = "seri";
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
            this.dataGridViewData.Location = new System.Drawing.Point(25, 225);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(736, 274);
            this.dataGridViewData.TabIndex = 42;
            // 
            // yard_kain
            // 
            this.yard_kain.HeaderText = "Yard Kain";
            this.yard_kain.Name = "yard_kain";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(87, 94);
            this.textBoxBrand.Multiline = true;
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(143, 28);
            this.textBoxBrand.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "BRAND   : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "ARTIKEL : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "ARTIKEL POTONG";
            // 
            // comboBoxArtikel
            // 
            this.comboBoxArtikel.BackColor = System.Drawing.Color.Khaki;
            this.comboBoxArtikel.FormattingEnabled = true;
            this.comboBoxArtikel.Location = new System.Drawing.Point(87, 60);
            this.comboBoxArtikel.Name = "comboBoxArtikel";
            this.comboBoxArtikel.Size = new System.Drawing.Size(143, 21);
            this.comboBoxArtikel.TabIndex = 48;
            this.comboBoxArtikel.SelectedIndexChanged += new System.EventHandler(this.comboBoxArtikel_SelectedIndexChanged);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Location = new System.Drawing.Point(662, 183);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(99, 36);
            this.buttonUbah.TabIndex = 49;
            this.buttonUbah.Text = "UBAH";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // textBoxXL
            // 
            this.textBoxXL.Location = new System.Drawing.Point(374, 167);
            this.textBoxXL.Multiline = true;
            this.textBoxXL.Name = "textBoxXL";
            this.textBoxXL.Size = new System.Drawing.Size(99, 28);
            this.textBoxXL.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "SIZE XL   : ";
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(374, 60);
            this.textBoxS.Multiline = true;
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(99, 28);
            this.textBoxS.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "SIZE S   :";
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(374, 133);
            this.textBoxL.Multiline = true;
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(99, 28);
            this.textBoxL.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "SIZE L   : ";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(374, 96);
            this.textBoxM.Multiline = true;
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(99, 28);
            this.textBoxM.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "SIZE M   : ";
            // 
            // textBoxYard
            // 
            this.textBoxYard.Location = new System.Drawing.Point(87, 164);
            this.textBoxYard.Multiline = true;
            this.textBoxYard.Name = "textBoxYard";
            this.textBoxYard.Size = new System.Drawing.Size(143, 28);
            this.textBoxYard.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "YARD KAIN :";
            // 
            // textBoxSeri
            // 
            this.textBoxSeri.Location = new System.Drawing.Point(87, 128);
            this.textBoxSeri.Multiline = true;
            this.textBoxSeri.Name = "textBoxSeri";
            this.textBoxSeri.Size = new System.Drawing.Size(143, 28);
            this.textBoxSeri.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "SERI   : ";
            // 
            // FormUbahArtPotong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 559);
            this.Controls.Add(this.textBoxSeri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxYard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxXL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.comboBoxArtikel);
            this.Controls.Add(this.buttonUbahBagian);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxKain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUbahArtPotong";
            this.Text = "FormUbahArtPotong";
            this.Load += new System.EventHandler(this.FormUbahArtPotong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUbahBagian;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxKain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeXL;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeM;
        private System.Windows.Forms.DataGridViewTextBoxColumn seri;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn yard_kain;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxArtikel;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.TextBox textBoxXL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxYard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSeri;
        private System.Windows.Forms.Label label6;
    }
}