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
    public partial class FormUpdateCustomer : Form
    {
        List<Pelanggan> listPelanggan = new List<Pelanggan>();
        public FormUpdateCustomer()
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
            FormDaftarCustomer formDaftarCustomer = (FormDaftarCustomer)this.Owner;
            formDaftarCustomer.FormDaftarCustomer_Load(pictureBoxClose, e);

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

        private void textBoxTelephone_Enter(object sender, EventArgs e)
        {
            if (textBoxTelephone.Text == "Tekephone")
            {
                textBoxTelephone.Text = "";

                textBoxTelephone.ForeColor = Color.Black;
            }
        }

        private void textBoxTelephone_Leave(object sender, EventArgs e)
        {
            if (textBoxTelephone.Text == "")
            {
                textBoxTelephone.Text = "Telephone";

                textBoxTelephone.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void FormUpdateCustomer_Load(object sender, EventArgs e)
        {
            textBoxKode.MaxLength = 2;
        }

        private void pictureBoxOk_Click(object sender, EventArgs e)
        {
            if (textBoxKode.Text == "")
            {
                MessageBox.Show("Code cannot be empty.", "Error");
            }
            else
            {
                try
                {
                    string telp;
                    if (textBoxTelephone.Text == "Telephone")
                    {
                        telp = "";
                    }
                    else
                    {
                        telp = textBoxTelephone.Text;
                    }
                    Pelanggan p = new Pelanggan(textBoxKode.Text, textBoxNama.Text, telp);

                    Pelanggan.UbahData(p);

                    MessageBox.Show("Customer data has been updated", "Info");

                    //munculkan di form daftar
                    FormDaftarCustomer formDaftarCustomer = (FormDaftarCustomer)this.Owner;
                    formDaftarCustomer.FormDaftarCustomer_Load(pictureBoxClose, e);

                    textBoxKode.Text = "";
                    textBoxNama.Text = "Name";
                    textBoxTelephone.Text = "Telephone";
                    textBoxNama.ForeColor = Color.Silver;
                    textBoxTelephone.ForeColor = Color.Silver;
                    textBoxKode.Focus();
                }
                catch (Exception exc)
                {

                    MessageBox.Show("Failed to update customer data. Error message : " + exc.Message, "Error");
                }
            }
        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKode.Text.Length == textBoxKode.MaxLength)
            {
                listPelanggan = Pelanggan.BacaData("KodePelanggan", textBoxKode.Text);
                if (listPelanggan.Count > 0)
                {
                    textBoxNama.Text = listPelanggan[0].Nama;
                    textBoxNama.Focus();

                    textBoxTelephone.Text = listPelanggan[0].Telepon;
                    if (textBoxTelephone.Text =="")
                    {
                        textBoxTelephone.Text = "Telephone";
                        textBoxTelephone.ForeColor = Color.Silver;
                    }
                }
                else
                {
                    MessageBox.Show("Code not found.", "Error");
                    textBoxNama.Text = "Name";
                    textBoxTelephone.Text = "Telephone";
                }
            }
            else if (textBoxKode.Text.Length <=1)
            {
                textBoxNama.Text = "Name";
                textBoxNama.ForeColor = Color.Silver;

                textBoxTelephone.Text = "Telephone";
                textBoxNama.ForeColor = Color.Silver;
            }
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
            textBoxNama.ForeColor = Color.Black;
        }

        private void textBoxTelephone_TextChanged(object sender, EventArgs e)
        {
            textBoxTelephone.ForeColor = Color.Black;
        }
    }
}
