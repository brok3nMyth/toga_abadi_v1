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
    public partial class FormTambahNotaJual : Form
    {
        FormUtama formUtama;
        List<Pelanggan> listPelanggan = new List<Pelanggan>();
        List<Barang> listBarang = new List<Barang>();
        NotaJual notaJual;
        public FormTambahNotaJual()
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
        private void textBoxNoNota_Enter(object sender, EventArgs e)
        {
            if (textBoxNoNota.Text == "Invoice No.")
            {
                textBoxNoNota.Text = "";

                textBoxNoNota.ForeColor = Color.Black;
            }
        }

        private void textBoxNoNota_Leave(object sender, EventArgs e)
        {
            if (textBoxNoNota.Text == "")
            {
                textBoxNoNota.Text = "Invoice No.";

                textBoxNoNota.ForeColor = Color.Silver;
            }
        }

        private void textBoxBarcode_Enter(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text == "Barcode")
            {
                textBoxBarcode.Text = "";

                textBoxBarcode.ForeColor = Color.Black;
            }
        }

        private void textBoxBarcode_Leave(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text == "")
            {
                textBoxBarcode.Text = "Barcode";

                textBoxBarcode.ForeColor = Color.Silver;
            }
        }

        private void textBoxDiskon_Enter(object sender, EventArgs e)
        {
            if (textBoxDiskon.Text == "Disc %")
            {
                textBoxDiskon.Text = "";

                textBoxDiskon.ForeColor = Color.Black;
            }
        }

        private void textBoxDiskon_Leave(object sender, EventArgs e)
        {
            if (textBoxDiskon.Text == "")
            {
                textBoxDiskon.Text = "Disc %";

                textBoxDiskon.ForeColor = Color.Silver;
            }
        }

        private void textBoxJumlah_Enter(object sender, EventArgs e)
        {
            if (textBoxJumlah.Text == "Qty")
            {
                textBoxJumlah.Text = "";

                textBoxJumlah.ForeColor = Color.Black;
            }
        }

        private void textBoxJumlah_Leave(object sender, EventArgs e)
        {
            if (textBoxJumlah.Text == "")
            {
                textBoxJumlah.Text = "Qty";

                textBoxJumlah.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void FormatDataGrid()
        {
            dataGridViewHasil.Columns.Clear();

            dataGridViewHasil.Columns.Add("KodeBarang", "Kode");
            dataGridViewHasil.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewHasil.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewHasil.Columns.Add("Jumlah", "Jumlah");
            dataGridViewHasil.Columns.Add("SubTotal", "SubTotal");

            dataGridViewHasil.Columns["KodeBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["NamaBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHasil.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewHasil.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewHasil.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewHasil.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewHasil.Columns["HargaJual"].DefaultCellStyle.Format = "#,###";
            dataGridViewHasil.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";

            dataGridViewHasil.AllowUserToAddRows = false;
            dataGridViewHasil.ReadOnly = true;
        }

        private void FormTambahNotaJual_Load(object sender, EventArgs e)
        {
            listPelanggan = Pelanggan.BacaData("", "");
            comboBoxPelanggan.DataSource = listPelanggan;
            comboBoxPelanggan.DisplayMember = "Nama";
            comboBoxPelanggan.DropDownStyle = ComboBoxStyle.DropDownList;

            formUtama = (FormUtama)this.Owner.MdiParent;

            textBoxNoNota.Text = NotaJual.GenerateNoNota();
            textBoxNoNota.Enabled = false;
            dateTimePickerTanggal.Value = DateTime.Now;
            FormatDataGrid();
            textBoxBarcode.MaxLength = 13;
        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text.Length == textBoxBarcode.MaxLength)
            {
                listBarang = Barang.BacaData("Barcode", textBoxBarcode.Text);
                if (listBarang.Count > 0)
                {
                    labelKode.Text = listBarang[0].KodeBarang;
                    labelNamaBarang.Text = listBarang[0].Nama;
                    labelHarga.Text = listBarang[0].HargaPerRoll.ToString();
                    textBoxJumlah.Text = "1";
                    textBoxJumlah.Focus();
                }
                else
                {
                    MessageBox.Show("Barang tidak ditemukan");
                    textBoxBarcode.Text = "";
                }
            }
        }

        private int HitungGrandTotal()
        {
            int grandTotal = 0;
            for (int i = 0; i < dataGridViewHasil.Rows.Count; i++)
            {
                int subTotal = int.Parse(dataGridViewHasil.Rows[i].Cells["Subtotal"].Value.ToString());
                grandTotal += subTotal;
            }
            return grandTotal;
        }

        private void textBoxJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pictureBoxSave_Click(object sender, EventArgs e)
        {
            try
            {
                Pelanggan pelangganDipilih = (Pelanggan)comboBoxPelanggan.SelectedItem;
                notaJual = new NotaJual(textBoxNoNota.Text, dateTimePickerTanggal.Value,pelangganDipilih);

            for (int i = 0; i < dataGridViewHasil.Rows.Count; i++)
                {
                    string kodeBrg = dataGridViewHasil.Rows[i].Cells["KodeBarang"].Value.ToString();
                    listBarang = Barang.BacaData("B.KodeBarang", kodeBrg);

                int harga = int.Parse(dataGridViewHasil.Rows[i].Cells["HargaJual"].Value.ToString());
                    int jumlah = int.Parse(dataGridViewHasil.Rows[i].Cells["Jumlah"].Value.ToString());
                    double diskon = double.Parse(textBoxDiskon.Text);

                    notaJual.TambahNotaJualDetil(listBarang[0], harga, jumlah, diskon);
                }

                NotaJual.TambahData(notaJual);
                MessageBox.Show("Data nota jual telah tersimpan.", "Informasi");
                pictureBoxPrint_Click(sender, e);
                FormDaftarInvoiceSales f = (FormDaftarInvoiceSales)this.Owner;
                f.FormDaftarInvoiceSales_Load(sender, e);
                this.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan nota. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void Clear()
        {
            textBoxNoNota.Text = NotaJual.GenerateNoNota();
            dateTimePickerTanggal.Value = DateTime.Now;
            comboBoxPelanggan.SelectedIndex = 0;
            labelGrandTotal.Text = "0";
            dataGridViewHasil.Rows.Clear();
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            try
            {
                NotaJual.CetakNota("NoNotaJual", textBoxNoNota.Text, "nota_jual.txt", new Font("Courier New", 12));

                MessageBox.Show("Nota jual telah tercetak");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nota jual gagal dicetak. Pesan kesalahan : " + ex.Message);
            }
        }

        private void textBoxJumlah_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double subTotal = ((int.Parse(labelHarga.Text) - (double.Parse(labelHarga.Text) * double.Parse(textBoxDiskon.Text)/100)) * int.Parse(textBoxJumlah.Text));
                dataGridViewHasil.Rows.Add(labelKode.Text, labelNamaBarang.Text, labelHarga.Text, textBoxJumlah.Text, subTotal);
                labelGrandTotal.Text = HitungGrandTotal().ToString("#,###");

                textBoxBarcode.Text = "";
                labelKode.Text = "";
                labelNamaBarang.Text = "";
                labelHarga.Text = "";
                textBoxJumlah.Text = "";
                textBoxBarcode.Focus();
            }
        }
    }
}
