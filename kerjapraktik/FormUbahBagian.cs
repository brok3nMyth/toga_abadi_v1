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
    public partial class FormUbahBagian : Form
    {
        public FormUbahBagian()
        {
            InitializeComponent();
        }
        List<Bagians> listbagian = new List<Bagians>();
        private void FormUbahBagian_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            TampilDataGrid();
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("bagian", "Bagian");
            dataGridViewData.Columns.Add("harga", "Harga");

            dataGridViewData.Columns["bagian"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            /* dataGridViewData.Columns["HargaBeli"].DefaultCellStyle.Format = "#,###";
             dataGridViewData.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";*/

            dataGridViewData.AllowUserToAddRows = true;
            dataGridViewData.ReadOnly = false;
        }
        private void TampilDataGrid()
        {
            if (listbagian.Count > 0)
            {
                dataGridViewData.Rows.Clear();
                foreach (Bagians b in listbagian)
                {
                    dataGridViewData.Rows.Add(b.Bagian, b.Biaya_Satuan);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }
    }
}
