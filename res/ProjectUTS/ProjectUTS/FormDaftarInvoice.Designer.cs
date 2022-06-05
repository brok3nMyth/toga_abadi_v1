namespace ProjectUTS
{
    partial class FormDaftarInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarInvoice));
            this.dataGridViewHasil = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.pictureBoxInsert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHasil
            // 
            this.dataGridViewHasil.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHasil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHasil.Location = new System.Drawing.Point(81, 222);
            this.dataGridViewHasil.Name = "dataGridViewHasil";
            this.dataGridViewHasil.RowTemplate.Height = 24;
            this.dataGridViewHasil.Size = new System.Drawing.Size(943, 568);
            this.dataGridViewHasil.TabIndex = 13;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearch.Location = new System.Drawing.Point(105, 66);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(730, 31);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Location = new System.Drawing.Point(1024, 61);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(46, 44);
            this.pictureBoxDelete.TabIndex = 12;
            this.pictureBoxDelete.TabStop = false;
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(958, 61);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(46, 44);
            this.pictureBoxUpdate.TabIndex = 11;
            this.pictureBoxUpdate.TabStop = false;
            // 
            // pictureBoxInsert
            // 
            this.pictureBoxInsert.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInsert.Location = new System.Drawing.Point(890, 61);
            this.pictureBoxInsert.Name = "pictureBoxInsert";
            this.pictureBoxInsert.Size = new System.Drawing.Size(46, 44);
            this.pictureBoxInsert.TabIndex = 10;
            this.pictureBoxInsert.TabStop = false;
            // 
            // FormDaftarInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 802);
            this.Controls.Add(this.dataGridViewHasil);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.pictureBoxInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDaftarInvoice";
            this.Text = "FormDaftarInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHasil;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.PictureBox pictureBoxInsert;
    }
}