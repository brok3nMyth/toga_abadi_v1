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
    public partial class FormTambahSupplier : Form
    {
        public FormTambahSupplier()
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
            FormDaftarSuppliers formDaftarSuppliers = (FormDaftarSuppliers)this.Owner;
            formDaftarSuppliers.FormDaftarSuppliers_Load(pictureBoxClose, e);

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
            if (textBoxTelephone.Text == "Telephone")
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

        private void FormTambahSupplier_Load(object sender, EventArgs e)
        {
            string kodeTerbaru = Supplier.GenerateKode();

            textBoxKode.Text = kodeTerbaru;
            textBoxKode.Enabled = false;
            textBoxKode.Focus();
        }

        private void pictureBoxOk_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                MessageBox.Show("Name cannot be empty", "Error");
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
                    Supplier s = new Supplier(textBoxKode.Text, textBoxNama.Text, telp);

                    Supplier.TambahData(s);

                    MessageBox.Show("New supplier has been saved", "Info");

                    //munculkan di form daftar
                    FormDaftarSuppliers formDaftarSuppliers = (FormDaftarSuppliers)this.Owner;
                    formDaftarSuppliers.FormDaftarSuppliers_Load(pictureBoxClose, e);

                    //generate kode baru lagi
                    string kodeTerbaru = Supplier.GenerateKode();
                    textBoxNama.Text = "";
                    textBoxNama.Focus();
                    textBoxTelephone.Text = "Telephone";
                    textBoxTelephone.ForeColor = Color.Silver;


                    textBoxKode.Text = kodeTerbaru;
                    textBoxKode.Enabled = false;
                    textBoxKode.Focus();
                }
                catch (Exception exc)
                {

                    MessageBox.Show("Failed to save new customer. Error Message : " + exc.Message, "Error");
                }
            }
        }
    }
}
