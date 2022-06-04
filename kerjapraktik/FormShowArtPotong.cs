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
    public partial class FormShowArtPotong : Form
    {
        public FormShowArtPotong()
        {
            InitializeComponent();
        }
        List<ArtikelPotongs> listap = new List<ArtikelPotongs>();
        private void FormShowArtPotong_Load(object sender, EventArgs e)
        {
            listap = ArtikelPotongs.BacaData("", "");
            FormatDataGrid();
            TampilDataGrid();
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("Artikel", "Artikel");
            dataGridViewData.Columns.Add("Brand", "Brand");
            dataGridViewData.Columns.Add("Kain", "Kain");
            dataGridViewData.Columns.Add("Seri", "Seri");
            dataGridViewData.Columns.Add("Yard", "Yard Kain");
            dataGridViewData.Columns.Add("S", "Size S");
            dataGridViewData.Columns.Add("M", "Size M");
            dataGridViewData.Columns.Add("L", "Size L");
            dataGridViewData.Columns.Add("XL", "Size XL");
            dataGridViewData.Columns.Add("Jumlah", "Jumlah");

            dataGridViewData.Columns["Artikel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Brand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Kain"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Seri"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Yard"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["S"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["M"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["L"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["XL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewData.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            /* dataGridViewData.Columns["HargaBeli"].DefaultCellStyle.Format = "#,###";
             dataGridViewData.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";*/

            dataGridViewData.AllowUserToAddRows = true;
            dataGridViewData.ReadOnly = false;
        }
        private void TampilDataGrid()
        {
            if (listap.Count > 0)
            {
                dataGridViewData.Rows.Clear();
                foreach (ArtikelPotongs ap in listap)
                {
                    int jumlahsize = ap.Size_S + ap.Size_M + ap.Size_L + ap.Size_XL;
                    dataGridViewData.Rows.Add(ap.IdArtikelPotongs, ap.Brand, ap.Kain, ap.Seri, ap.Yard, ap.Size_S, ap.Size_M, ap.Size_L, ap.Size_XL, jumlahsize);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }  

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listap = ArtikelPotongs.BacaData(comboBoxKolom.Text, textBoxSearch.Text);
            TampilDataGrid();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listap = ArtikelPotongs.BacaData("", "");
            FormatDataGrid();
            TampilDataGrid();
        }
    }
}
