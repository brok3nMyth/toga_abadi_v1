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
    public partial class FormDaftarKategori : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();
        public FormDaftarKategori()
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
            selected = "Kode";
        }

        private void pictureBoxNama_Click(object sender, EventArgs e)
        {
            pictureBoxKode.BackgroundImage = Properties.Resources.kode;
            pictureBoxNama.BackgroundImage = Properties.Resources.nama_selected;
            selected = "Nama";
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
            FormTambahKategori formTambahKategori = new FormTambahKategori();
            formTambahKategori.Owner = this;
            formTambahKategori.Show();
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateKategori formUpdateKategori = new FormUpdateKategori();
            formUpdateKategori.Owner = this;
            formUpdateKategori.Show();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            FormDeleteKategori formDeleteKategori = new FormDeleteKategori();
            formDeleteKategori.Owner = this;
            formDeleteKategori.Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (selected == "Kode")
            {
                listKategori = Kategori.BacaData("KodeKategori", textBoxSearch.Text);
            }
            else if (selected == "Nama")
            {
                listKategori = Kategori.BacaData("Nama", textBoxSearch.Text);
            }

            if (listKategori.Count > 0)
            {
                dataGridViewHasil.DataSource = listKategori;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        public void FormDaftarKategori_Load(object sender, EventArgs e)
        {
            selected = "Kode";
            listKategori = Kategori.BacaData("", "");

            if (listKategori.Count > 0)
            {
                dataGridViewHasil.DataSource = listKategori;
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }
    }
}
