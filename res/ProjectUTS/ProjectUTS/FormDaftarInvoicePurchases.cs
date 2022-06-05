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
    public partial class FormDaftarInvoicePurchases : Form
    {
        List<NotaBeli> listOfNotaBeli = new List<NotaBeli>();
        string selected = "";

        public FormDaftarInvoicePurchases()
        {
            InitializeComponent();
        }
        #region UI SETTINGS
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

        private void pictureBoxInvNo_Click(object sender, EventArgs e)
        {
            pictureBoxInvNo.BackgroundImage = Properties.Resources.invoiceno_selected;
            pictureBoxTgl.BackgroundImage = Properties.Resources.date;
            pictureBoxSupCode.BackgroundImage = Properties.Resources.suppliercode;
            pictureBoxSupName.BackgroundImage = Properties.Resources.suppliername;
            pictureBoxSupTelp.BackgroundImage = Properties.Resources.suppliertelp;
            selected = "N.NoNotaBeli";
        }

        private void pictureBoxTgl_Click(object sender, EventArgs e)
        {
            pictureBoxInvNo.BackgroundImage = Properties.Resources.invoiceno;
            pictureBoxTgl.BackgroundImage = Properties.Resources.date_selected;
            pictureBoxSupCode.BackgroundImage = Properties.Resources.suppliercode;
            pictureBoxSupName.BackgroundImage = Properties.Resources.suppliername;
            pictureBoxSupTelp.BackgroundImage = Properties.Resources.suppliertelp;
            selected = "N.Tanggal";
        }

        private void pictureBoxSupCode_Click(object sender, EventArgs e)
        {
            pictureBoxInvNo.BackgroundImage = Properties.Resources.invoiceno;
            pictureBoxTgl.BackgroundImage = Properties.Resources.date;
            pictureBoxSupCode.BackgroundImage = Properties.Resources.suppliercode_selected;
            pictureBoxSupName.BackgroundImage = Properties.Resources.suppliername;
            pictureBoxSupTelp.BackgroundImage = Properties.Resources.suppliertelp;
            selected = "N.KodeSupplier";
        }

        private void pictureBoxSupName_Click(object sender, EventArgs e)
        {
            pictureBoxInvNo.BackgroundImage = Properties.Resources.invoiceno;
            pictureBoxTgl.BackgroundImage = Properties.Resources.date;
            pictureBoxSupCode.BackgroundImage = Properties.Resources.suppliercode;
            pictureBoxSupName.BackgroundImage = Properties.Resources.suppliername_selected;
            pictureBoxSupTelp.BackgroundImage = Properties.Resources.suppliertelp;
            selected = "s.Nama";
        }

        private void pictureBoxSupTelp_Click(object sender, EventArgs e)
        {
            pictureBoxInvNo.BackgroundImage = Properties.Resources.invoiceno;
            pictureBoxTgl.BackgroundImage = Properties.Resources.date;
            pictureBoxSupCode.BackgroundImage = Properties.Resources.suppliercode;
            pictureBoxSupName.BackgroundImage = Properties.Resources.suppliername;
            pictureBoxSupTelp.BackgroundImage = Properties.Resources.suppliertelp_selected;
            selected = "S.Telepon";
        }
        #endregion

        private void pictureBoxInsert_Click(object sender, EventArgs e)
        {
            FormTambahNotaBeli form = new FormTambahNotaBeli();
            form.Owner = this;
            form.Show();
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            NotaBeli.CetakNota(selected, textBoxSearch.Text, "nota_jual.txt", new Font("Courier New", 12));
        }

        private void FormatDataGrid()
        {
            dataGridViewHasil.Columns.Add("NoNota", "Invoice No.");
            dataGridViewHasil.Columns.Add("Tanggal", "Date");
            dataGridViewHasil.Columns.Add("KodeSupplier", "Supplier Code");
            dataGridViewHasil.Columns.Add("NamaSupplier", "Supplier Name");
            dataGridViewHasil.Columns.Add("TelpSupplier", "Supplier Telephone");
            dataGridViewHasil.Columns.Add("KodeBarang", "Product Code");
            dataGridViewHasil.Columns.Add("NamaBarang", "Product Name");
            dataGridViewHasil.Columns.Add("Harga", "Price");
            dataGridViewHasil.Columns.Add("Jumlah", "Quantity");

            dataGridViewHasil.Columns["NoNota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["KodeSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["NamaSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["TelpSupplier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["KodeBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["NamaBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewHasil.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewHasil.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewHasil.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewHasil.AllowUserToAddRows = false;
            dataGridViewHasil.ReadOnly = true;
        }

        private void TampilkanDataGrid()
        {
            dataGridViewHasil.Rows.Clear();

            if (listOfNotaBeli.Count > 0)
            {
                foreach (NotaBeli n in listOfNotaBeli)
                {
                    foreach (NotaBeliDetil nbd in n.ListNotaBeliDetil)
                    {
                        dataGridViewHasil.Rows.Add(n.NoNotaBeli, n.Tanggal, n.Supplier.KodeSupplier, n.Supplier.Nama, n.Supplier.Telepon,
                            nbd.Barang.KodeBarang, nbd.Barang.Nama, nbd.Harga, nbd.Jumlah);
                    }
                }
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        public void FormDaftarInvoicePurchases_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listOfNotaBeli = NotaBeli.BacaData("", "");

            TampilkanDataGrid();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            selected = "N.NoNotaBeli";

            listOfNotaBeli = NotaBeli.BacaData(selected, textBoxSearch.Text);
            TampilkanDataGrid();
        }
    }
}
