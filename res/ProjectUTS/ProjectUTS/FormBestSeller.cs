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
    public partial class FormBestSeller : Form
    {
        List<Barang> listBarang = new List<Barang>();
        public FormBestSeller()
        {
            InitializeComponent();
        }

        #region UI Settings
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
        #endregion

        private void FormBestSeller_Load(object sender, EventArgs e)
        {
            FormatDatagrid();
        }

        private void FormatDatagrid()
        {
            dataGridViewHasil.Columns.Clear();

            dataGridViewHasil.Columns.Add("KodeBarang", "Kode Barang");
            dataGridViewHasil.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewHasil.Columns.Add("Jumlah", "Jumlah");
        }


        private void BulanTahun()
        {
            if (comboBoxYear.Text != "" && comboBoxBulan.Text != "")
            {
                string a = (comboBoxBulan.SelectedIndex + 1).ToString();
                string b = comboBoxYear.Text;
                listBarang = Barang.PenjualanTerbanyak(a, b);

                dataGridViewHasil.Rows.Clear();
                foreach (Barang barang in listBarang)
                {
                    dataGridViewHasil.Rows.Add(barang.KodeBarang, barang.Nama, barang.Jumlah.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("Pilih Tahun/Bulan terlebih dahulu");
            }
        }

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            BulanTahun();
            
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            BulanTahun();
        }


    }
}
