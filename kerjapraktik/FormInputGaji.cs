using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogaAbadiClassHitung;

namespace kerjapraktik
{
    public partial class FormInputGaji : Form
    {
        public FormInputGaji()
        {
            InitializeComponent();
        }
        List<Terambils> listT = new List<Terambils>();
        List<Bagians> listBagian = new List<Bagians>();
        List<ArtikelPotongs> listAp = new List<ArtikelPotongs>();
        List<Gajis> listGaji = new List<Gajis>();

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonKunciGaji_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Enabled == true)
            {
                textBoxNama.Enabled = false;
                textBoxTempat.Enabled = false;
                dateTimePickerTanggalGajian.Enabled = false;
                buttonKunciGaji.Text = "Lepas Kunci";
            }
            else
            {
                textBoxNama.Enabled = true;
                textBoxTempat.Enabled = true;
                dateTimePickerTanggalGajian.Enabled = true;
                buttonKunciGaji.Text = "Kunci Gaji";
            }
        }

        private void FormInputGaji_Load(object sender, EventArgs e)
        {

        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            listBagian = Bagians.BacaData("id_artikel", textBoxArt.Text);
            comboBoxBagian.DataSource = listBagian;
            comboBoxBagian.DisplayMember = "bagian";
            FormatDataGridBagian();
            TampilDataGridBagian();
        }

        private void FormatDataGridBagian()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("bagian", "Bagian");
            dataGridViewData.Columns.Add("tersedia", "Tersedia"); //diambil
            dataGridViewData.Columns.Add("harga", "Harga");

            dataGridViewData.Columns["bagian"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["tersedia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewData.AllowUserToAddRows = true;
            dataGridViewData.ReadOnly = false;
        }
        private void TampilDataGridBagian()
        {
            if (listBagian.Count > 0)
            {
                dataGridViewData.Rows.Clear();
                foreach (Bagians b in listBagian)
                {
                    dataGridViewDataBagian.Rows.Add(b.Bagian,b.Tersedia, b.Biaya_Satuan);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }

        private void FormatDataGrid()
        {//sisi kanan
            dataGridViewData.Columns.Clear();
            //ubahen sek ini sesuai sg mbok mau aku bingung bacae
            dataGridViewData.Columns.Add("bagian", "Bagian");
            dataGridViewData.Columns.Add("tersedia", "Tersedia"); 
            dataGridViewData.Columns.Add("harga", "Harga");

            dataGridViewData.Columns["bagian"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["tersedia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewData.AllowUserToAddRows = true;
            dataGridViewData.ReadOnly = false;
        }
        private void TampilDataGrid()
        {//sisi kanan
            //iki sisan
            if (listBagian.Count > 0)
            {
                dataGridViewData.Rows.Clear();
                foreach (Bagians b in listBagian)
                {
                    dataGridViewDataBagian.Rows.Add(b.Bagian, b.Tersedia, b.Biaya_Satuan);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }

        private void buttonTambahBagian_Click(object sender, EventArgs e)
        {
            //Gajis g = new Gajis();
            //listGaji = Gajis.BacaData
            //Bagians b = new Bagians();
            //Terambils t = new Terambils()
            //Terambils.TambahData()
        }
    }
}
