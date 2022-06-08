
namespace kerjapraktik
{
    partial class FormInputPegawai
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
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.labelWarna = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNIK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDomisili = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.Black;
            this.buttonSimpan.Location = new System.Drawing.Point(12, 195);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(117, 41);
            this.buttonSimpan.TabIndex = 35;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Black;
            this.buttonKeluar.Location = new System.Drawing.Point(345, 195);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(111, 41);
            this.buttonKeluar.TabIndex = 37;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // labelWarna
            // 
            this.labelWarna.BackColor = System.Drawing.SystemColors.Control;
            this.labelWarna.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarna.ForeColor = System.Drawing.Color.Black;
            this.labelWarna.Location = new System.Drawing.Point(12, 9);
            this.labelWarna.Name = "labelWarna";
            this.labelWarna.Size = new System.Drawing.Size(444, 41);
            this.labelWarna.TabIndex = 38;
            this.labelWarna.Text = "TAMBAH PEGAWAI";
            this.labelWarna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(146, 14);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(279, 30);
            this.textBoxNama.TabIndex = 25;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(19, 15);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(121, 16);
            this.labelNama.TabIndex = 26;
            this.labelNama.Text = "NAMA PEGAWAI :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxDomisili);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxNIK);
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 122);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "NIK : ";
            // 
            // textBoxNIK
            // 
            this.textBoxNIK.Location = new System.Drawing.Point(146, 51);
            this.textBoxNIK.Multiline = true;
            this.textBoxNIK.Name = "textBoxNIK";
            this.textBoxNIK.Size = new System.Drawing.Size(279, 30);
            this.textBoxNIK.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "DOMISILI :";
            // 
            // textBoxDomisili
            // 
            this.textBoxDomisili.Location = new System.Drawing.Point(146, 89);
            this.textBoxDomisili.Multiline = true;
            this.textBoxDomisili.Name = "textBoxDomisili";
            this.textBoxDomisili.Size = new System.Drawing.Size(279, 30);
            this.textBoxDomisili.TabIndex = 29;
            // 
            // FormInputPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 268);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWarna);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonSimpan);
            this.Name = "FormInputPegawai";
            this.Text = "FormInputPegawai";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label labelWarna;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDomisili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNIK;
    }
}