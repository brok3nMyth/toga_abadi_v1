
namespace kerjapraktik
{
    partial class FormUbahPegawai
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
            this.labelWarna = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.labelNama = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.comboBoxPegawai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDomisili = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNIK = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWarna
            // 
            this.labelWarna.BackColor = System.Drawing.SystemColors.Control;
            this.labelWarna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelWarna.ForeColor = System.Drawing.Color.Black;
            this.labelWarna.Location = new System.Drawing.Point(3, 9);
            this.labelWarna.Name = "labelWarna";
            this.labelWarna.Size = new System.Drawing.Size(444, 41);
            this.labelWarna.TabIndex = 42;
            this.labelWarna.Text = "UBAH PEGAWAI";
            this.labelWarna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonSimpan.ForeColor = System.Drawing.Color.Black;
            this.buttonSimpan.Location = new System.Drawing.Point(2, 278);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(117, 41);
            this.buttonSimpan.TabIndex = 40;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.Color.Transparent;
            this.labelNama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(19, 60);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(121, 16);
            this.labelNama.TabIndex = 26;
            this.labelNama.Text = "NAMA PEGAWAI :";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(146, 59);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(279, 30);
            this.textBoxNama.TabIndex = 25;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.Black;
            this.labelId.Location = new System.Drawing.Point(43, 26);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(96, 16);
            this.labelId.TabIndex = 22;
            this.labelId.Text = "ID PEGAWAI :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxDomisili);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxNIK);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Controls.Add(this.comboBoxPegawai);
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Location = new System.Drawing.Point(3, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 210);
            this.panel1.TabIndex = 39;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonCheck.ForeColor = System.Drawing.Color.Black;
            this.buttonCheck.Location = new System.Drawing.Point(305, 14);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(120, 32);
            this.buttonCheck.TabIndex = 42;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // comboBoxPegawai
            // 
            this.comboBoxPegawai.FormattingEnabled = true;
            this.comboBoxPegawai.Location = new System.Drawing.Point(146, 21);
            this.comboBoxPegawai.Name = "comboBoxPegawai";
            this.comboBoxPegawai.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPegawai.TabIndex = 27;
            this.comboBoxPegawai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "DOMISILI :";
            // 
            // textBoxDomisili
            // 
            this.textBoxDomisili.Location = new System.Drawing.Point(146, 136);
            this.textBoxDomisili.Multiline = true;
            this.textBoxDomisili.Name = "textBoxDomisili";
            this.textBoxDomisili.Size = new System.Drawing.Size(279, 30);
            this.textBoxDomisili.TabIndex = 45;
            this.textBoxDomisili.TextChanged += new System.EventHandler(this.textBoxDomisili_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "NIK : ";
            // 
            // textBoxNIK
            // 
            this.textBoxNIK.Location = new System.Drawing.Point(146, 98);
            this.textBoxNIK.Multiline = true;
            this.textBoxNIK.Name = "textBoxNIK";
            this.textBoxNIK.Size = new System.Drawing.Size(279, 30);
            this.textBoxNIK.TabIndex = 43;
            // 
            // FormUbahPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 328);
            this.Controls.Add(this.labelWarna);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.panel1);
            this.Name = "FormUbahPegawai";
            this.Text = "FormUbahPegawai";
            this.Load += new System.EventHandler(this.FormUbahPegawai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWarna;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPegawai;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDomisili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNIK;
    }
}