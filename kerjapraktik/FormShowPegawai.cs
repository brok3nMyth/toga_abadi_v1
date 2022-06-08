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
    public partial class FormShowPegawai : Form
    {
        public FormShowPegawai()
        {
            InitializeComponent();
        }
        List<Pekerjas> listp = new List<Pekerjas>();
        private void FormShowPegawai_Load(object sender, EventArgs e)
        {
            listp = Pekerjas.BacaData("", "");
            FormatDataGrid();
            TampilDataGrid();
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("id", "Id");
            dataGridViewData.Columns.Add("nama", "Nama");
            dataGridViewData.Columns.Add("nik", "NIK");
            dataGridViewData.Columns.Add("alamat", "Alamat");

            dataGridViewData.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["nik"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            /* dataGridViewData.Columns["HargaBeli"].DefaultCellStyle.Format = "#,###";
             dataGridViewData.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";*/

            dataGridViewData.AllowUserToAddRows = true;
            dataGridViewData.ReadOnly = false;
        }
        private void TampilDataGrid()
        {
            if (listp.Count > 0)
            {
                dataGridViewData.Rows.Clear();
                foreach (Pekerjas p in listp)
                {
                    dataGridViewData.Rows.Add(p.IdPekerjas,p.Nama,p.Nik,p.Alamat_domisili);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listp = Pekerjas.BacaData(comboBoxKolom.Text, textBoxSearch.Text);
            TampilDataGrid();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listp = Pekerjas.BacaData("", "");
            FormatDataGrid();
            TampilDataGrid();
        }
    }
}
