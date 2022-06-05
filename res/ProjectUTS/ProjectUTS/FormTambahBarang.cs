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
    public partial class FormTambahBarang : Form
    {
        List<Kategori> listKategori = new List<Kategori>();
        public FormTambahBarang()
        {
            InitializeComponent();
        }
        #region UI Settings
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

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
                textBoxNama.Text = "Name";

                textBoxNama.ForeColor = Color.Silver;
            }
        }

        private void textBoxHRoll_Enter(object sender, EventArgs e)
        {
            if (textBoxHRoll.Text == "Price/Roll")
            {
                textBoxHRoll.Text = "";

                textBoxHRoll.ForeColor = Color.Black;
            }
        }

        private void textBoxHRoll_Leave(object sender, EventArgs e)
        {
            if (textBoxHRoll.Text == "")
            {
                textBoxHRoll.Text = "Price/Roll";

                textBoxHRoll.ForeColor = Color.Silver;
            }
        }

        private void textBoxHmeter_Enter(object sender, EventArgs e)
        {
            if (textBoxHmeter.Text == "Price/M")
            {
                textBoxHmeter.Text = "";

                textBoxHmeter.ForeColor = Color.Black;
            }
        }

        private void textBoxHmeter_Leave(object sender, EventArgs e)
        {
            if (textBoxHmeter.Text == "")
            {
                textBoxHmeter.Text = "Price/M";

                textBoxHmeter.ForeColor = Color.Silver;
            }
        }

        private void textBoxStock_Enter(object sender, EventArgs e)
        {
            if (textBoxStock.Text == "Stock")
            {
                textBoxStock.Text = "";

                textBoxStock.ForeColor = Color.Black;
            }
        }

        private void textBoxStock_Leave(object sender, EventArgs e)
        {
            if (textBoxStock.Text == "")
            {
                textBoxStock.Text = "Stock";

                textBoxStock.ForeColor = Color.Silver;
            }
        }

        private void textBoxDiameter_Enter(object sender, EventArgs e)
        {
            if (textBoxDiameter.Text == "Diameter")
            {
                textBoxDiameter.Text = "";

                textBoxDiameter.ForeColor = Color.Black;
            }
        }

        private void textBoxDiameter_Leave(object sender, EventArgs e)
        {
            if (textBoxDiameter.Text == "")
            {
                textBoxDiameter.Text = "Diameter";

                textBoxDiameter.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void FormTambahBarang_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.BacaData("", "");

            comboBoxKategori.DataSource = listKategori;
            comboBoxKategori.DisplayMember = "Nama";

            textBoxKode.MaxLength = 5;
        }

        private void Clear()
        {
            textBoxNama.Text = "Name";
            textBoxNama.ForeColor = Color.Silver;
            textBoxHmeter.Text = "Price/M";
            textBoxHmeter.ForeColor = Color.Silver;
            textBoxHRoll.Text = "Price/Roll";
            textBoxHRoll.ForeColor = Color.Silver;
            textBoxDiameter.Text = "Diameter";
            textBoxDiameter.ForeColor = Color.Silver;
            textBoxStock.Text = "Stock";
            textBoxStock.ForeColor = Color.Silver;
        }
        private void pictureBoxOk_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                MessageBox.Show("Name cannot be empty", "Error");
            }
            else
            {
                int hmeter;
                try
                {
                    if (textBoxHRoll.Text == "Price/Roll")
                    {
                        MessageBox.Show("Price/Roll cannot be empty");
                    }

                    if (textBoxHmeter.Text == "Price/M")
                    {
                        hmeter = 0;
                    }
                    else
                    {
                        hmeter = int.Parse(textBoxHmeter.Text);
                    }

                    Kategori selectedKategori = (Kategori)comboBoxKategori.SelectedItem;

                    Barang b = new Barang(textBoxKode.Text, "12345678" + textBoxKode.Text, textBoxNama.Text, int.Parse(textBoxHRoll.Text), hmeter,
                        int.Parse(textBoxStock.Text), double.Parse(textBoxDiameter.Text), selectedKategori);

                    Barang.TambahData(b);

                    MessageBox.Show("New product has been saved", "Info");

                    Clear();

                    //munculkan di form daftar
                    FormDaftarBarang formDaftarBarang = (FormDaftarBarang)this.Owner;
                    formDaftarBarang.FormDaftarBarang_Load(pictureBoxClose, e);

                    //generate kode baru lagi
                    string kodeTerbaru = Barang.GenerateKode(selectedKategori);
                    textBoxNama.Text = "";
                    textBoxNama.Focus();

                    textBoxKode.Text = kodeTerbaru;
                    textBoxKode.Enabled = false;
                    textBoxKode.Focus();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Failed to save new product. Error Message : " + exc.Message, "Kesalahan");
                }
            }  
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategori selectedKategori = (Kategori)comboBoxKategori.SelectedItem;

            string kodeBarang = Barang.GenerateKode(selectedKategori);

            textBoxKode.Text = kodeBarang;
            textBoxKode.Enabled = false;

            textBoxKode.Focus();
        }
    }
}
