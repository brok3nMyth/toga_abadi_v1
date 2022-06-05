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
    public partial class FormDeleteBarang : Form
    {
        List<Barang> listBarang = new List<Barang>();
        public FormDeleteBarang()
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
                textBoxNama.Text = "Code";

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

        private void FormDeleteBarang_Load(object sender, EventArgs e)
        {
            textBoxKode.MaxLength = 5;
        }

        private void pictureBoxOk_Click(object sender, EventArgs e)
        {
            if (textBoxKode.Text == "")
            {
                MessageBox.Show("Code cannot be empty.", "Error");
            }
            else
            {
                DialogResult konfirmasi = MessageBox.Show("The selected product will be deleted. Are you sure?",
                    "Confirmation", MessageBoxButtons.YesNo);

                if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        listBarang = Barang.BacaData("KodeBarang", textBoxKode.Text);
                        Kategori selectedKategori = new Kategori(listBarang[0].Kategori.KodeKategori, listBarang[0].Kategori.Nama);
                        Barang b = new Barang(textBoxKode.Text, "12345678"+textBoxKode.Text, textBoxNama.Text, listBarang[0].HargaPerRoll,
                            listBarang[0].HargaPerMeter, int.Parse(textBoxStock.Text), double.Parse(textBoxDiameter.Text),
                            selectedKategori);

                        Barang.HapusData(b);

                        MessageBox.Show("Selected product has been deleted", "Info");

                        //Refresh form delete dan form kategori
                        textBoxKode.Text = "";
                        textBoxNama.Text = "Name";
                        textBoxCategory.Text = "Category";
                        textBoxHRoll.Text = "Price/Roll";
                        textBoxHmeter.Text = "Price/M";
                        textBoxStock.Text = "Stock";
                        textBoxDiameter.Text = "Diameter";
                        textBoxKode.Focus();

                        FormDaftarBarang formDaftarBarang = (FormDaftarBarang)this.Owner;
                        formDaftarBarang.FormDaftarBarang_Load(pictureBoxClose, e);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Failed to delete product. Error Message : " + exc.Message, "Error");
                    }
                }
            }
        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKode.Text.Length == textBoxKode.MaxLength)
            {
                listBarang = Barang.BacaData("KodeBarang", textBoxKode.Text);
                if (listBarang.Count > 0)
                {
                    textBoxNama.Text = listBarang[0].Nama;

                    if (listBarang[0].HargaPerRoll == 0)
                    {
                        textBoxHRoll.Text = "";
                    }
                    else
                    {
                        textBoxHRoll.Text = (listBarang[0].HargaPerRoll).ToString();
                    }

                    if (listBarang[0].HargaPerMeter==0)
                    {
                        textBoxHmeter.Text = "";
                    }
                    else
                    {
                        textBoxHmeter.Text = (listBarang[0].HargaPerMeter).ToString();
                    }


                    textBoxStock.Text= (listBarang[0].Stock).ToString();

                    textBoxDiameter.Text= (listBarang[0].Diameter).ToString();

                    textBoxCategory.Text = (listBarang[0].Kategori.Nama);
                }
                else
                {
                    MessageBox.Show("Code not found.", "Error");
                    textBoxNama.Text = "Name";
                    textBoxCategory.Text = "Category";
                    textBoxHRoll.Text = "Price/Roll";
                    textBoxHmeter.Text = "Price/M";
                    textBoxStock.Text = "Stock";
                    textBoxDiameter.Text = "Diameter";
                }
            }
            else if (textBoxKode.Text.Length <= 1)
            {
                textBoxNama.Text = "Name";
                textBoxCategory.Text = "Category";
                textBoxHRoll.Text = "Price/Roll";
                textBoxHmeter.Text = "Price/M";
                textBoxStock.Text = "Stock";
                textBoxDiameter.Text = "Diameter";
            }
        }
    }
}
