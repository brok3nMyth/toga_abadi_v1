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
    public partial class FormDaftarInvoiceSales : Form
    {
        List<NotaJual> listOfNotaJual = new List<NotaJual>();
        string selected = "";

        public FormDaftarInvoiceSales()
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
            pictureBoxCustCode.BackgroundImage = Properties.Resources.customercode;
            pictureBoxCustName.BackgroundImage = Properties.Resources.customername;
            pictureBoxCustTelp.BackgroundImage = Properties.Resources.customertelp;
            selected = "N.NoNotaJual";
        }

        private void pictureBoxTgl_Click(object sender, EventArgs e)
        {
            pictureBoxInvNo.BackgroundImage = Properties.Resources.invoiceno;
            pictureBoxTgl.BackgroundImage = Properties.Resources.date_selected;
            pictureBoxCustCode.BackgroundImage = Properties.Resources.customercode;
            pictureBoxCustName.BackgroundImage = Properties.Resources.customername;
            pictureBoxCustTelp.BackgroundImage = Properties.Resources.customertelp;
            selected = "N.Tanggal";
        }

        private void pictureBoxCustCode_Click(object sender, EventArgs e)
        {
            pictureBoxInvNo.BackgroundImage = Properties.Resources.invoiceno;
            pictureBoxTgl.BackgroundImage = Properties.Resources.date;
            pictureBoxCustCode.BackgroundImage = Properties.Resources.customercode_selected;
            pictureBoxCustName.BackgroundImage = Properties.Resources.customername;
            pictureBoxCustTelp.BackgroundImage = Properties.Resources.customertelp;
            selected = "N.KodePelanggan";
        }

        private void pictureBoxCustName_Click(object sender, EventArgs e)
        {
            pictureBoxInvNo.BackgroundImage = Properties.Resources.invoiceno;
            pictureBoxTgl.BackgroundImage = Properties.Resources.date;
            pictureBoxCustCode.BackgroundImage = Properties.Resources.customercode;
            pictureBoxCustName.BackgroundImage = Properties.Resources.customername_selected;
            pictureBoxCustTelp.BackgroundImage = Properties.Resources.customertelp;
            selected = "Pelanggan.Nama";
        }

        private void pictureBoxCustTelp_Click(object sender, EventArgs e)
        {
            pictureBoxInvNo.BackgroundImage = Properties.Resources.invoiceno;
            pictureBoxTgl.BackgroundImage = Properties.Resources.date;
            pictureBoxCustCode.BackgroundImage = Properties.Resources.customercode;
            pictureBoxCustName.BackgroundImage = Properties.Resources.customername;
            pictureBoxCustTelp.BackgroundImage = Properties.Resources.customertelp_selected;
            selected = "Pelanggan.Telepon";
        }
        #endregion

        private void pictureBoxInsert_Click(object sender, EventArgs e)
        {
            FormTambahNotaJual form = new FormTambahNotaJual();
            form.Owner = this;
            form.Show();
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            NotaJual.CetakNota(selected, textBoxSearch.Text, "nota_jual.txt", new Font("Courier New", 12));
        }
        
        private void FormatDataGrid()
        {
            dataGridViewHasil.Columns.Clear();

            dataGridViewHasil.Columns.Add("NoNota", "Invoice No.");
            dataGridViewHasil.Columns.Add("Tanggal", "Date");
            dataGridViewHasil.Columns.Add("KodePelanggan", "Customer Code");
            dataGridViewHasil.Columns.Add("NamaPelanggan", "Customer Name");
            dataGridViewHasil.Columns.Add("TelpPelanggan", "Customer Telephone");
            dataGridViewHasil.Columns.Add("KodeBarang", "Product Code");
            dataGridViewHasil.Columns.Add("NamaBarang", "Product Name");
            dataGridViewHasil.Columns.Add("Harga", "Price");
            dataGridViewHasil.Columns.Add("Jumlah", "Quantity");

            dataGridViewHasil.Columns["NoNota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["Tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["KodePelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["NamaPelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["TelpPelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void TampilDataGrid()
        {
            dataGridViewHasil.Rows.Clear();

            if (listOfNotaJual.Count > 0)
            {
                foreach (NotaJual n in listOfNotaJual)
                {
                    foreach (NotaJualDetil njd in n.ListNotaJualDetil)
                    {
                        dataGridViewHasil.Rows.Add(n.KodeNotaJual, n.Tanggal, n.Pelanggan.KodePelanggan, n.Pelanggan.Nama, n.Pelanggan.Telepon,
                            njd.Barang.KodeBarang, njd.Barang.Nama, njd.Harga, njd.Jumlah);
                    }
                }
            }
            else
            {
                dataGridViewHasil.DataSource = null;
            }
        }

        public void FormDaftarInvoiceSales_Load(object sender, EventArgs e)
        {
            selected = "N.NoNotaJual";

            FormatDataGrid();

            listOfNotaJual = NotaJual.BacaData("", "");

            TampilDataGrid();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listOfNotaJual = NotaJual.BacaData(selected, textBoxSearch.Text);
            TampilDataGrid();
        }
    }
}
