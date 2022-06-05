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
        public static string idPegawai= "";

        private void FormShowGaji_Load(object sender, EventArgs e)
        {
            listgaji = Gajis.BacaData2("", "");

            FormatDataGrid();
            TampilDataGrid();
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("id", "Id");
            dataGridViewData.Columns.Add("pekerjas_nama", "Nama Pekerja"); 
            dataGridViewData.Columns.Add("subtotal", "Subtotal");
            dataGridViewData.Columns.Add("kasbon", "Kasbon");
            dataGridViewData.Columns.Add("total", "Total Gaji");

            dataGridViewData.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["pekerjas_nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["kasbon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            /* dataGridViewData.Columns["HargaBeli"].DefaultCellStyle.Format = "#,###";
             dataGridViewData.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";*/

            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.ReadOnly = true;
        }
        private void TampilDataGrid()
        {
            if (listgaji.Count > 0)
            {
                dataGridViewData.Rows.Clear();
                foreach (Gajis g in listgaji)
                {
                    dataGridViewData.Rows.Add(g.IdGaji, g.Nama, g.Subtotal, g.Kasbon, g.TotalGaji);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listgaji = Gajis.BacaData2(comboBoxKolom.Text, textBoxSearch.Text);
            TampilDataGrid();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listgaji = Gajis.BacaData2("", "");
            FormatDataGrid();
            TampilDataGrid();
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*idPegawai = dataGridViewData.Rows;*//*
            if (idPegawai== "")
            {
                MessageBox.Show("Error data kosong", "Peringatan");
            }
            else
            {
                Form form = Application.OpenForms["FormShowGajiDetail"];
                if (form == null)
                {
                    FormShowGajiDetail formShowGajiDetail = new FormShowGajiDetail();
                    formShowGajiDetail.MdiParent = this.MdiParent;
                    formShowGajiDetail.Show();
                }
                else
                {
                    form.Show();
                    form.BringToFront();
                }
            }*/
        }
    }
}
