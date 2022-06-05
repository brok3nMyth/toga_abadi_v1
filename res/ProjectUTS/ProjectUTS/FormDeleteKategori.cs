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
    public partial class FormDeleteKategori : Form
    {
        List<Kategori> listKategori = new List<Kategori>();
        public FormDeleteKategori()
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
            if (textBoxKode.Text=="")
            {
                MessageBox.Show("Code cannot be empty.", "Error");
            }
            else
            {
                DialogResult konfirmasi = MessageBox.Show("The selected category will be deleted. Are you sure?",
                    "Confirmation", MessageBoxButtons.YesNo);

                if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Kategori k = new Kategori(textBoxKode.Text, textBoxNama.Text);

                        Kategori.HapusData(k);

                        MessageBox.Show("Selected category has been deleted", "Info");

                        //Refresh form delete dan form kategori
                        textBoxKode.Text = "";
                        FormDaftarKategori formDaftarKategori = (FormDaftarKategori)this.Owner;
                        formDaftarKategori.FormDaftarKategori_Load(pictureBoxClose, e);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Failed to delete category. Error Message : " + exc.Message, "Error");
                    }
                }
            }
        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKode.Text.Length == textBoxKode.MaxLength)
            {
                listKategori = Kategori.BacaData("KodeKategori", textBoxKode.Text);
                if (listKategori.Count > 0)
                {
                    textBoxNama.Text = listKategori[0].Nama;
                    textBoxNama.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Code not found.", "Error");
                }
            }
            else if (textBoxKode.Text.Length<=1)
            {
                textBoxNama.Text = "Name";
                textBoxNama.Enabled = false;
            }
        }

        private void FormDeleteKategori_Load(object sender, EventArgs e)
        {
            textBoxKode.MaxLength = 2;
        }
    }
}
