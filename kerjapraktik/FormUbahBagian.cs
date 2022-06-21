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
        List<ArtikelPotongs> listAp = new List<ArtikelPotongs>();
        private void FormUbahBagian_Load(object sender, EventArgs e)
        {
            textBoxIDArt.Text = FormUbahArtPotong.AP;

            listbagian = Bagians.BacaData("id_artikel", textBoxIDArt.Text);
            comboBoxBagian.DataSource = listbagian;
            comboBoxBagian.DisplayMember = "bagian";
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

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                bool checkfill=CheckFill();
                if (checkfill == true)
                {
                    string bagian = comboBoxBagian.Text.ToString();
                    string kodeAp1 = textBoxIDArt.Text;
                    int biaya = int.Parse(textBoxHarga.Text);
                    listAp = ArtikelPotongs.BacaData("id", kodeAp1);
                    string kodeAP2 = listAp[0].IdArtikelPotongs.ToString();
                    string brand = listAp[0].Brand.ToString();
                    string kain = listAp[0].Kain.ToString();
                    string seri = listAp[0].Seri.ToString();
                    int yard = int.Parse(listAp[0].Yard.ToString());
                    int s = int.Parse(listAp[0].Size_S.ToString());
                    int m = int.Parse(listAp[0].Size_M.ToString());
                    int l = int.Parse(listAp[0].Size_L.ToString());
                    int xl = int.Parse(listAp[0].Size_XL.ToString());
                    ArtikelPotongs ap = new ArtikelPotongs(kodeAP2, brand, kain, seri, yard, s, m, l, xl);
                    int ketersediaan = ArtikelPotongs.HitungTotalOrder(ap);

                    Bagians b = new Bagians(bagian, ketersediaan, biaya);
                    //ubah data
                    Bagians.UbahData(b, kodeAP2);
                    listbagian = Bagians.BacaData("id_artikel", textBoxIDArt.Text);
                    TampilDataGrid();
                    MessageBox.Show("bagian " + bagian + " berhasil diubah.");
                }
                else
                {
                    MessageBox.Show("Textbox cannot be empty");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("msg: "+ ex);
            }
            
        }
        private bool CheckFill()
        {
            bool filled = false;
            if (textBoxHarga.Text != "" && textBoxIDArt.Text != "" && comboBoxBagian.Text != "")
            {
                filled = true;
            }
            return filled;
        }
    }
}
