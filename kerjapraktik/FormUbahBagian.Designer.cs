
namespace kerjapraktik
{
    partial class FormUbahBagian
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
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.Bagian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBagian = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDArt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bagian,
            this.Biaya});
            this.dataGridViewData.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(315, 223);
            this.dataGridViewData.TabIndex = 15;
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
            // buttonUbah
            // 
            this.buttonUbah.Location = new System.Drawing.Point(264, 104);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(63, 25);
            this.buttonUbah.TabIndex = 14;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(65, 77);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(100, 20);
            this.textBoxHarga.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bagian";
            // 
            // comboBoxBagian
            // 
            this.comboBoxBagian.FormattingEnabled = true;
            this.comboBoxBagian.Location = new System.Drawing.Point(65, 48);
            this.comboBoxBagian.Name = "comboBoxBagian";
            this.comboBoxBagian.Size = new System.Drawing.Size(262, 21);
            this.comboBoxBagian.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Artikel";
            // 
            // textBoxIDArt
            // 
            this.textBoxIDArt.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBoxIDArt.Enabled = false;
            this.textBoxIDArt.Location = new System.Drawing.Point(65, 22);
            this.textBoxIDArt.Name = "textBoxIDArt";
            this.textBoxIDArt.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDArt.TabIndex = 8;
            // 
            // FormUbahBagian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 372);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBagian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDArt);
            this.Name = "FormUbahBagian";
            this.Text = "FormUbahBagian";
            this.Load += new System.EventHandler(this.FormUbahBagian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bagian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biaya;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBagian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDArt;
    }
}