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
    public partial class FormTambahKategori : Form
    {
        public FormTambahKategori()
        {
            InitializeComponent();
        }
        #region UI Settings
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
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
            FormDaftarKategori formDaftarKategori = (FormDaftarKategori)this.Owner;
            formDaftarKategori.FormDaftarKategori_Load(pictureBoxClose, e);

            this.Close();
        }

        private void textBoxKode_Enter(object sender, EventArgs e)
        {
            if (textBoxKode.Text == "Code")
            {
                textBoxKode.Text = "";

                textBoxKode.ForeColor = Color.Black;
            }
        }

        private void textBoxKode_Leave(object sender, EventArgs e)
        {
            if (textBoxKode.Text == "")
            {
                textBoxKode.Text = "Code";

                textBoxKode.ForeColor = Color.Silver;
            }
        }

        private void textBoxNama_Enter(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "Name")
            {
                textBoxNama.Text = "";

                textBoxNama.ForeColor = Color.Black;
            }
        }

        private void textBoxNama_Leave(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                textBoxNama.Text = "Nama";

                textBoxNama.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void pictureBoxOk_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text=="")
            {
                MessageBox.Show("Name cannot be empty", "Error");
            }
            else
            {
                try
                {
                    Kategori k = new Kategori(textBoxKode.Text, textBoxNama.Text);

                    Kategori.TambahData(k);

                    MessageBox.Show("New category has been saved", "Message");

                    //munculkan di form daftar
                    FormDaftarKategori formDaftarKategori = (FormDaftarKategori)this.Owner;
                    formDaftarKategori.FormDaftarKategori_Load(pictureBoxClose, e);

                    //generate kode baru lagi
                    string kodeTerbaru = Kategori.GenerateKode();
                    textBoxNama.Text = "";

                    textBoxKode.Text = kodeTerbaru;
                    textBoxKode.Enabled = false;
                    textBoxKode.Focus();

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Failed to save new category. Error Message : " + exc.Message, "Error");
                }
            }
        }

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {
            string kodeTerbaru = Kategori.GenerateKode();

            textBoxKode.Text = kodeTerbaru;
            textBoxKode.Enabled = false;
            textBoxKode.Focus();
        }
    }
}
