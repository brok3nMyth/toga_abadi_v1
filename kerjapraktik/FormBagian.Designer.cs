
namespace kerjapraktik
{
    partial class FormBagian
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
            this.textBoxIDArt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBagian = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bagian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIDArt
            // 
            this.textBoxIDArt.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBoxIDArt.Enabled = false;
            this.textBoxIDArt.Location = new System.Drawing.Point(68, 24);
            this.textBoxIDArt.Name = "textBoxIDArt";
            this.textBoxIDArt.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDArt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Artikel";
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
            this.comboBoxBagian.Location = new System.Drawing.Point(68, 51);
            this.comboBoxBagian.Name = "comboBoxBagian";
            this.comboBoxBagian.Size = new System.Drawing.Size(276, 21);
            this.comboBoxBagian.TabIndex = 2;
            this.comboBoxBagian.SelectedIndexChanged += new System.EventHandler(this.comboBoxBagian_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bagian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga";
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(68, 80);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(100, 20);
            this.textBoxHarga.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(185, 99);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(63, 25);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bagian,
            this.Biaya});
            this.dataGridView1.Location = new System.Drawing.Point(15, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 249);
            this.dataGridView1.TabIndex = 7;
            // 
            // Bagian
            // 
            this.Bagian.HeaderText = "ColumnBagian";
            this.Bagian.Name = "Bagian";
            // 
            // Biaya
            // 
            this.Biaya.HeaderText = "ColumnBiaya";
            this.Biaya.Name = "Biaya";
            // 
            // FormBagian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 391);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBagian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDArt);
            this.Name = "FormBagian";
            this.Text = "Form Bagian";
            this.Load += new System.EventHandler(this.FormBagian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBagian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bagian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biaya;
    }
}