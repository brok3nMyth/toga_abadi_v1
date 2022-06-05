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
using classProject;

namespace ProjectUTS
{
    public partial class FormDaftarSuppliers : Form
    {
        List<Supplier> listSupplier = new List<Supplier>();
        public FormDaftarSuppliers()
        {
            InitializeComponent();
        }
        string selected = "";
        #region UI Settings
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search")
            {
                textBoxSearch.Text = "";

                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Search";

                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void pictureBoxKode_Click(object sender, EventArgs e)
        {
            pictureBoxKode.BackgroundImage = Properties.Resources.kode_selected;
            pictureBoxNama.BackgroundImage = Properties.Resources.nama;
            pictureBoxTelp.BackgroundImage = Properties.Resources.phone;
            selected = "Kode";
        }

        private void pictureBoxNama_Click(object sender, EventArgs e)
        {
            pictureBoxKode.BackgroundImage = Properties.Resources.kode;
            pictureBoxNama.BackgroundImage = Properties.Resources.nama_selected;
            pictureBoxTelp.BackgroundImage = Properties.Resources.phone;
            selected = "Nama";
        }

        private void pictureBoxTelp_Click(object sender, EventArgs e)
        {
            pictureBoxKode.BackgroundImage = Properties.Resources.kode;
            pictureBoxNama.BackgroundImage = Properties.Resources.nama;
            pictureBoxTelp.BackgroundImage = Properties.Resources.phone_selected;
            selected = "Telephone";
        }

        private void panelBorder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void pictureBoxInsert_Click(object sender, EventArgs e)
        {
            FormTambahSupplier formTambahSupplier = new FormTambahSupplier();
            formTambahSupplier.Owner = this;
            formTambahSupplier.Show();
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateSupplier formUpdateSupplier = new FormUpdateSupplier();
            formUpdateSupplier.Owner = this;
            formUpdateSupplier.Show();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            FormDeleteSupplier formDeleteSupplier = new FormDeleteSupplier();
            formDeleteSupplier.Owner = this;
            formDeleteSupplier.Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (selected == "Kode")
            {
                listSupplier = Supplier.BacaData("KodeSupplier", textBoxSearch.Text);
            }
            else if (selected == "Nama")
            {
                listSupplier = Supplier.BacaData("Nama", textBoxSearch.Text);
            }
            else if (selected == "Telephone")
            {
                listSupplier = Supplier.BacaData("Telepon", textBoxSearch.Text);
            }

            if (listSupplier.Count > 0)
            {
                dataGridViewHasil.DataSource = listSupplier;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        public void FormDaftarSuppliers_Load(object sender, EventArgs e)
        {
            selected = "Kode";
            listSupplier = Supplier.BacaData("", "");

            if (listSupplier.Count > 0)
            {
                dataGridViewHasil.DataSource = listSupplier;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }
    }
}
