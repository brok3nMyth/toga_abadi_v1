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
         
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("Seri", "Seri");
            dataGridViewData.Columns.Add("Yard Kain", "Yard");
            dataGridViewData.Columns.Add("Size M", "M");
            dataGridViewData.Columns.Add("Size L", "L");
            dataGridViewData.Columns.Add("Size XL", "XL");
            dataGridViewData.Columns.Add("Jumlah", "Jumlah");


            dataGridViewData.Columns["KodeBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewData.Columns["HargaBeli"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           

            dataGridViewData.Columns["HargaBeli"].DefaultCellStyle.Format = "#,###";
            dataGridViewData.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";

            dataGridViewData.AllowUserToAddRows = true;
            dataGridViewData.ReadOnly = false;
        }
    }
}
