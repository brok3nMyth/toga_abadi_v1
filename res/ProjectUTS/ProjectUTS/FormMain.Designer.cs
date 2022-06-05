namespace ProjectUTS
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelBorder = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxProducts = new System.Windows.Forms.PictureBox();
            this.pictureBoxKategori = new System.Windows.Forms.PictureBox();
            this.pictureBoxInvoice = new System.Windows.Forms.PictureBox();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.pictureBoxSupplier = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.Transparent;
            this.panelBorder.Controls.Add(this.pictureBoxClose);
            this.panelBorder.Controls.Add(this.pictureBoxMinimize);
            this.panelBorder.Location = new System.Drawing.Point(393, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(1109, 50);
            this.panelBorder.TabIndex = 0;
            this.panelBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBorder_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Location = new System.Drawing.Point(1061, 7);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1024, 7);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxMinimize.TabIndex = 1;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // pictureBoxProducts
            // 
            this.pictureBoxProducts.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxProducts.Location = new System.Drawing.Point(0, 273);
            this.pictureBoxProducts.Name = "pictureBoxProducts";
            this.pictureBoxProducts.Size = new System.Drawing.Size(406, 70);
            this.pictureBoxProducts.TabIndex = 1;
            this.pictureBoxProducts.TabStop = false;
            this.pictureBoxProducts.Click += new System.EventHandler(this.pictureBoxProducts_Click);
            this.pictureBoxProducts.MouseEnter += new System.EventHandler(this.pictureBoxProducts_MouseEnter);
            this.pictureBoxProducts.MouseLeave += new System.EventHandler(this.pictureBoxProducts_MouseLeave);
            // 
            // pictureBoxKategori
            // 
            this.pictureBoxKategori.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKategori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxKategori.Location = new System.Drawing.Point(0, 351);
            this.pictureBoxKategori.Name = "pictureBoxKategori";
            this.pictureBoxKategori.Size = new System.Drawing.Size(406, 70);
            this.pictureBoxKategori.TabIndex = 2;
            this.pictureBoxKategori.TabStop = false;
            this.pictureBoxKategori.Click += new System.EventHandler(this.pictureBoxKategori_Click);
            this.pictureBoxKategori.MouseEnter += new System.EventHandler(this.pictureBoxKategori_MouseEnter);
            this.pictureBoxKategori.MouseLeave += new System.EventHandler(this.pictureBoxKategori_MouseLeave);
            // 
            // pictureBoxInvoice
            // 
            this.pictureBoxInvoice.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInvoice.Location = new System.Drawing.Point(0, 430);
            this.pictureBoxInvoice.Name = "pictureBoxInvoice";
            this.pictureBoxInvoice.Size = new System.Drawing.Size(406, 70);
            this.pictureBoxInvoice.TabIndex = 3;
            this.pictureBoxInvoice.TabStop = false;
            this.pictureBoxInvoice.Click += new System.EventHandler(this.pictureBoxInvoice_Click);
            this.pictureBoxInvoice.MouseEnter += new System.EventHandler(this.pictureBoxInvoice_MouseEnter);
            this.pictureBoxInvoice.MouseLeave += new System.EventHandler(this.pictureBoxInvoice_MouseLeave);
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCustomer.Location = new System.Drawing.Point(0, 508);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(406, 70);
            this.pictureBoxCustomer.TabIndex = 4;
            this.pictureBoxCustomer.TabStop = false;
            this.pictureBoxCustomer.Click += new System.EventHandler(this.pictureBoxCustomer_Click);
            this.pictureBoxCustomer.MouseEnter += new System.EventHandler(this.pictureBoxCustomer_MouseEnter);
            this.pictureBoxCustomer.MouseLeave += new System.EventHandler(this.pictureBoxCustomer_MouseLeave);
            // 
            // pictureBoxSupplier
            // 
            this.pictureBoxSupplier.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSupplier.Location = new System.Drawing.Point(0, 588);
            this.pictureBoxSupplier.Name = "pictureBoxSupplier";
            this.pictureBoxSupplier.Size = new System.Drawing.Size(406, 70);
            this.pictureBoxSupplier.TabIndex = 5;
            this.pictureBoxSupplier.TabStop = false;
            this.pictureBoxSupplier.Click += new System.EventHandler(this.pictureBoxSupplier_Click);
            this.pictureBoxSupplier.MouseEnter += new System.EventHandler(this.pictureBoxSupplier_MouseEnter);
            this.pictureBoxSupplier.MouseLeave += new System.EventHandler(this.pictureBoxSupplier_MouseLeave);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.Location = new System.Drawing.Point(394, 47);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1106, 802);
            this.panelForm.TabIndex = 6;
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.pictureBoxSupplier);
            this.Controls.Add(this.pictureBoxCustomer);
            this.Controls.Add(this.pictureBoxInvoice);
            this.Controls.Add(this.pictureBoxKategori);
            this.Controls.Add(this.pictureBoxProducts);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxProducts;
        private System.Windows.Forms.PictureBox pictureBoxKategori;
        private System.Windows.Forms.PictureBox pictureBoxInvoice;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.PictureBox pictureBoxSupplier;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Timer timerCheck;
    }
}