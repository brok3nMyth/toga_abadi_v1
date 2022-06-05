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
    public partial class FormDaftarBarang : Form
    {
        List<Barang> listBarang = new List<Barang>();
        public FormDaftarBarang()
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
            pictureBoxHroll.BackgroundImage = Properties.Resources.hroll;
            pictureBoxHmeter.BackgroundImage = Properties.Resources.hmeter;
            pictureBoxStock.BackgroundImage = Properties.Resources.stock;
            pictureBoxDiameter.BackgroundImage = Properties.Resources.diameter;
            selected = "Kode";
        }

        private void pictureBoxNama_Click(object sender, EventArgs e)
        {
            pictureBoxKode.BackgroundImage = Properties.Resources.kode;
            pictureBoxNama.BackgroundImage = Properties.Resources.nama_selected;
            pictureBoxHroll.BackgroundImage = Properties.Resources.hroll;
            pictureBoxHmeter.BackgroundImage = Properties.Resources.hmeter;
            pictureBoxStock.BackgroundImage = Properties.Resources.stock;
            pictureBoxDiameter.BackgroundImage = Properties.Resources.diameter;
            selected = "Nama";
        }

        private void pictureBoxHroll_Click(object sender, EventArgs e)
        {
            pictureBoxKode.BackgroundImage = Properties.Resources.kode;
            pictureBoxNama.BackgroundImage = Properties.Resources.nama;
            pictureBoxHroll.BackgroundImage = Properties.Resources.hroll_selected;
            pictureBoxHmeter.BackgroundImage = Properties.Resources.hmeter;
            pictureBoxStock.BackgroundImage = Properties.Resources.stock;
            pictureBoxDiameter.BackgroundImage = Properties.Resources.diameter;
            selected = "Hroll";
        }

        private void pictureBoxHmeter_Click(object sender, EventArgs e)
        {
            pictureBoxKode.BackgroundImage = Properties.Resources.kode;
            pictureBoxNama.BackgroundImage = Properties.Resources.nama;
            pictureBoxHroll.BackgroundImage = Properties.Resources.hroll;
            pictureBoxHmeter.BackgroundImage = Properties.Resources.hmeter_selected;
            pictureBoxStock.BackgroundImage = Properties.Resources.stock;
            pictureBoxDiameter.BackgroundImage = Properties.Resources.diameter;
            selected = "Hmeter";
        }

        private void pictureBoxStock_Click(object sender, EventArgs e)
        {
            pictureBoxKode.BackgroundImage = Properties.Resources.kode;
            pictureBoxNama.BackgroundImage = Properties.Resources.nama;
            pictureBoxHroll.BackgroundImage = Properties.Resources.hroll;
            pictureBoxHmeter.BackgroundImage = Properties.Resources.hmeter;
            pictureBoxStock.BackgroundImage = Properties.Resources.stock_selected;
            pictureBoxDiameter.BackgroundImage = Properties.Resources.diameter;
            selected = "Stock";
        }

        private void pictureBoxDiameter_Click(object sender, EventArgs e)
        {
            pictureBoxKode.BackgroundImage = Properties.Resources.kode;
            pictureBoxNama.BackgroundImage = Properties.Resources.nama;
            pictureBoxHroll.BackgroundImage = Properties.Resources.hroll;
            pictureBoxHmeter.BackgroundImage = Properties.Resources.hmeter;
            pictureBoxStock.BackgroundImage = Properties.Resources.stock;
            pictureBoxDiameter.BackgroundImage = Properties.Resources.diameter_selected;
            selected = "Diameter";
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
            FormTambahBarang formTambahBarang = new FormTambahBarang();
            formTambahBarang.Owner = this;
            formTambahBarang.Show();
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateBarang formUpdateBarang = new FormUpdateBarang();
            formUpdateBarang.Owner = this;
            formUpdateBarang.Show();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            FormDeleteBarang formDeleteBarang = new FormDeleteBarang();
            formDeleteBarang.Owner = this;
            formDeleteBarang.Show();
        }

        private void FormatDataGrid()
        {
            dataGridViewHasil.Columns.Clear();

            dataGridViewHasil.Columns.Add("KodeBarang", "Kode Barang");
            dataGridViewHasil.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewHasil.Columns.Add("HargaPerRoll", "Harga Per Roll");
            dataGridViewHasil.Columns.Add("HargaPerMeter", "Harga Per Meter");
            dataGridViewHasil.Columns.Add("Stock", "Stock");
            dataGridViewHasil.Columns.Add("Diameter", "Diameter");
            dataGridViewHasil.Columns.Add("KodeKategori", "Kode Kategori");
            dataGridViewHasil.Columns.Add("NamaKategori", "Nama Kategori");

            dataGridViewHasil.Columns["KodeBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["NamaBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["HargaPerRoll"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["HargaPerMeter"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["Diameter"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["Stock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewHasil.Columns["KodeKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewHasil.Columns["HargaPerRoll"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewHasil.Columns["HargaPerMeter"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewHasil.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewHasil.Columns["Diameter"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dataGridViewHasil.Columns["HargaPerRoll"].DefaultCellStyle.Format = "#,###";
            dataGridViewHasil.Columns["HargaPerMeter"].DefaultCellStyle.Format = "#,###";
        }

        private void TampilDataGrid()
        {
            if (listBarang.Count > 0)
            {
                dataGridViewHasil.Rows.Clear();
                foreach (Barang b in listBarang)
                {
                    dataGridViewHasil.Rows.Add(b.KodeBarang, b.Nama, b.HargaPerRoll, b.HargaPerMeter, b.Stock, b.Diameter,
                        b.Kategori.KodeKategori, b.Kategori.Nama);
                }
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (selected == "Kode") 
            {
                kriteria = "B.KodeBarang";
            }
            else if (selected == "Nama")
            {
                kriteria = "B.Nama";
            }
            else if (selected == "Hroll")
            {
                kriteria = "B.HargaPerRoll";
            }
            else if (selected == "Hmeter")
            {
                kriteria = "B.HargaPerMeter";
            }
            else if (selected == "Stock")
            {
                kriteria = "B.Stock";
            }
            else if (selected == "Diameter")
            {
                kriteria = "B.Diameter";
            }

            listBarang = Barang.BacaData(kriteria, textBoxSearch.Text);

            TampilDataGrid();
        }

        public void FormDaftarBarang_Load(object sender, EventArgs e)
        {
            selected = "Kode";

            FormatDataGrid();

            listBarang = Barang.BacaData("", "");

            TampilDataGrid();
        }

        private void pictureBoxBestSeller_Click(object sender, EventArgs e)
        {
            FormBestSeller formBestSeller = new FormBestSeller();
            formBestSeller.Owner = this;
            formBestSeller.Show();
        }
    }
}
