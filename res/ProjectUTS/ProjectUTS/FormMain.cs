using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUTS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        #region UI Settings
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        string selectedForm = "";

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBorder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxProducts_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxProducts.BackgroundImage = Properties.Resources.prod_selected;
        }

        private void pictureBoxProducts_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxProducts.BackgroundImage = null;
        }

        private void pictureBoxKategori_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxKategori.BackgroundImage = Properties.Resources.kat_selected;
        }

        private void pictureBoxKategori_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxKategori.BackgroundImage = null;
        }

        private void pictureBoxInvoice_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxInvoice.BackgroundImage = Properties.Resources.inv_selected;
        }

        private void pictureBoxInvoice_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxInvoice.BackgroundImage = null;

        }

        private void pictureBoxCustomer_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCustomer.BackgroundImage = Properties.Resources.cust_selected;
        }

        private void pictureBoxCustomer_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCustomer.BackgroundImage = null;
        }

        private void pictureBoxSupplier_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSupplier.BackgroundImage = Properties.Resources.sup_selected;
        }

        private void pictureBoxSupplier_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSupplier.BackgroundImage = null;
        }

        private void pictureBoxProducts_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            FormDaftarBarang formDaftarBarang = new FormDaftarBarang();
            formDaftarBarang.TopLevel = false;
            panelForm.Controls.Add(formDaftarBarang);
            formDaftarBarang.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formDaftarBarang.Dock = DockStyle.Fill;
            formDaftarBarang.Show();
            selectedForm = "Products";
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (selectedForm == "Products")
            {
                pictureBoxProducts.BackgroundImage = Properties.Resources.prod_selected;
                pictureBoxKategori.BackgroundImage = null;
                pictureBoxInvoice.BackgroundImage = null;
                pictureBoxCustomer.BackgroundImage = null;
                pictureBoxSupplier.BackgroundImage = null;
            }
            else if (selectedForm == "Category")
            {
                pictureBoxKategori.BackgroundImage = Properties.Resources.kat_selected;
                pictureBoxProducts.BackgroundImage = null;
                pictureBoxInvoice.BackgroundImage = null;
                pictureBoxCustomer.BackgroundImage = null;
                pictureBoxSupplier.BackgroundImage = null;
            }
            else if (selectedForm == "Invoice")
            {
                pictureBoxKategori.BackgroundImage = null; ;
                pictureBoxProducts.BackgroundImage = null;
                pictureBoxInvoice.BackgroundImage = Properties.Resources.inv_selected;
                pictureBoxCustomer.BackgroundImage = null;
                pictureBoxSupplier.BackgroundImage = null;
            }
            else if (selectedForm == "Customer")
            {
                pictureBoxKategori.BackgroundImage = null;
                pictureBoxProducts.BackgroundImage = null;
                pictureBoxInvoice.BackgroundImage = null;
                pictureBoxCustomer.BackgroundImage = Properties.Resources.cust_selected;
                pictureBoxSupplier.BackgroundImage = null;
            }
            else if (selectedForm == "Supplier")
            {
                pictureBoxKategori.BackgroundImage = null;
                pictureBoxProducts.BackgroundImage = null;
                pictureBoxInvoice.BackgroundImage = null;
                pictureBoxCustomer.BackgroundImage = null;
                pictureBoxSupplier.BackgroundImage = Properties.Resources.sup_selected;
            }
        }

        private void pictureBoxKategori_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            FormDaftarKategori formDaftarKategori = new FormDaftarKategori();
            formDaftarKategori.TopLevel = false;
            panelForm.Controls.Add(formDaftarKategori);
            formDaftarKategori.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formDaftarKategori.Dock = DockStyle.Fill;
            formDaftarKategori.Show();
            selectedForm = "Category";
        }

        private void pictureBoxInvoice_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            FormDaftarInvoice formDaftarInvoice = new FormDaftarInvoice();
            formDaftarInvoice.TopLevel = false;
            panelForm.Controls.Add(formDaftarInvoice);
            formDaftarInvoice.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formDaftarInvoice.Dock = DockStyle.Fill;
            formDaftarInvoice.Show();
            selectedForm = "Invoice";
        }

        private void pictureBoxCustomer_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            FormDaftarCustomer formDaftarCustomer = new FormDaftarCustomer();
            formDaftarCustomer.TopLevel = false;
            panelForm.Controls.Add(formDaftarCustomer);
            formDaftarCustomer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formDaftarCustomer.Dock = DockStyle.Fill;
            formDaftarCustomer.Show();
            selectedForm = "Customer";
        }

        private void pictureBoxSupplier_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            FormDaftarSuppliers formDaftarSuppliers  = new FormDaftarSuppliers();
            formDaftarSuppliers.TopLevel = false;
            panelForm.Controls.Add(formDaftarSuppliers);
            formDaftarSuppliers.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formDaftarSuppliers.Dock = DockStyle.Fill;
            formDaftarSuppliers.Show();
            selectedForm = "Supplier";
        }
        #endregion
    }
}
