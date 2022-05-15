using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kerjapraktik
{
    public partial class FormInputArtikelPotong : Form
    {
        public FormInputArtikelPotong()
        {
            InitializeComponent();
        }

        private void buttonTambahBagian_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormBagian"];
            if (form == null)
            {
                FormBagian formBagian = new FormBagian();
                formBagian.MdiParent = this.MdiParent;
                formBagian.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void FormInputArtikelPotong_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("Seri", "Seri");
            dataGridViewData.Columns.Add("Yard Kain", "Yard");
            dataGridViewData.Columns.Add("Size S", "S");
            dataGridViewData.Columns.Add("Size M", "M");
            dataGridViewData.Columns.Add("Size L", "L");
            dataGridViewData.Columns.Add("Size XL", "XL");
            dataGridViewData.Columns.Add("Jumlah", "Jumlah");

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
