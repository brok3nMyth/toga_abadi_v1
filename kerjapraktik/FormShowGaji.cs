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
    public partial class FormShowGaji : Form
    {
        public FormShowGaji()
        {
            InitializeComponent();
        }
        List<Gajis> listgaji = new List<Gajis>();
        private void FormShowGaji_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            TampilDataGrid();
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("id", "Id");
            dataGridViewData.Columns.Add("pekerjas_nama", "Nama Pekerja");
            dataGridViewData.Columns.Add("kodeAP", "Artikel");
            dataGridViewData.Columns.Add("models_nama", "Model");
            dataGridViewData.Columns.Add("harga_satuan", "Harga Satuan");
            dataGridViewData.Columns.Add("diambil", "Diambil");
            dataGridViewData.Columns.Add("subtotal", "Subtotal");
            dataGridViewData.Columns.Add("kasbon", "Kasbon");
            dataGridViewData.Columns.Add("total", "Total Gaji");

            dataGridViewData.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["pekerjas_nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["kodeAP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["models_nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["harga_satuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["diambil"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["kasbon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            /* dataGridViewData.Columns["HargaBeli"].DefaultCellStyle.Format = "#,###";
             dataGridViewData.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";*/

            dataGridViewData.AllowUserToAddRows = true;
            dataGridViewData.ReadOnly = false;
        }
        private void TampilDataGrid()
        {
            if (listgaji.Count > 0)
            {
                dataGridViewData.Rows.Clear();
                foreach (Gajis g in listgaji)
                {
                    dataGridViewData.Rows.Add(g.IdGaji, g.Pekerjas.Nama, g.Bagians.ArtikelPotongs.IdArtikelPotongs,
                        g.Bagians.Bagian, g.Bagians.Biaya_Satuan, g.Diambil, g.Subtotal, g.Kasbon, g.TotalGaji);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }
    }
}
