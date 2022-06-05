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
    public partial class FormDaftarCustomer : Form
    {
        List<Pelanggan> listPelanggan = new List<Pelanggan>();
        public FormDaftarCustomer()
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

                textBoxSearch.ForeColor = Color.Silver;
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
            FormTambahCustomer formTambahCustomer = new FormTambahCustomer();
            formTambahCustomer.Owner = this;
            formTambahCustomer.Show();
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateCustomer formUpdateCustomer = new FormUpdateCustomer();
            formUpdateCustomer.Owner = this;
            formUpdateCustomer.Show();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            FormDeleteCustomer formDeleteCustomer = new FormDeleteCustomer();
            formDeleteCustomer.Owner = this;
            formDeleteCustomer.Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (selected == "Kode")
            {
                listPelanggan = Pelanggan.BacaData("KodePelanggan", textBoxSearch.Text);
            }
            else if (selected == "Nama")
            {
                listPelanggan = Pelanggan.BacaData("Nama", textBoxSearch.Text);
            }
            else if (selected == "Telephone")
            {
                listPelanggan = Pelanggan.BacaData("Telepon", textBoxSearch.Text);
            }

            if (listPelanggan.Count > 0)
            {
                dataGridViewHasil.DataSource = listPelanggan;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        public void FormDaftarCustomer_Load(object sender, EventArgs e)
        {
            selected = "Kode";
            listPelanggan = Pelanggan.BacaData("", "");

            if (listPelanggan.Count > 0)
            {
                dataGridViewHasil.DataSource = listPelanggan;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }
    }
}
