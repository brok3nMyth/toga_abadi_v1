using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUTS
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            this.Enabled = false;

            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            formLogin.Show();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarKategori"];

            if (form == null)
            {
                FormDaftarKategori frmKategori = new FormDaftarKategori();
                frmKategori.MdiParent = this;
                frmKategori.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarBarang"];

            if (form == null)
            {
                FormDaftarBarang frmBarang = new FormDaftarBarang();
                frmBarang.MdiParent = this;
                frmBarang.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarCustomer"];

            if (form == null)
            {
                FormDaftarCustomer frmPelanggan = new FormDaftarCustomer();
                frmPelanggan.MdiParent = this;
                frmPelanggan.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarSupplier"];

            if (form == null)
            {
                FormDaftarSuppliers frmSupplier = new FormDaftarSuppliers();
                frmSupplier.MdiParent = this;
                frmSupplier.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void keluarSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarInvoiceSales"];

            if (form == null)
            {
                FormDaftarInvoiceSales frmInvoiceSales = new FormDaftarInvoiceSales();
                frmInvoiceSales.MdiParent = this;
                frmInvoiceSales.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaftarInvoicePurchases"];

            if (form == null)
            {
                FormDaftarInvoicePurchases frmInvoicePurchases = new FormDaftarInvoicePurchases();
                frmInvoicePurchases.MdiParent = this;
                frmInvoicePurchases.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void mostSoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormBestSeller"];

            if(form == null)
            {
                FormBestSeller frmBestSeller = new FormBestSeller();
                frmBestSeller.MdiParent = this;
                frmBestSeller.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
