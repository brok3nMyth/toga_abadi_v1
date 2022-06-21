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
    public partial class FormBagian : Form
    {
        public FormBagian()
        {
            InitializeComponent();
        }
        List<Bagians> listbagian = new List<Bagians>();
        List<ArtikelPotongs> listAp = new List<ArtikelPotongs>();

        private void FormBagian_Load(object sender, EventArgs e)
        {
            //comboBoxBagian.DataSource = listbagian;
            //comboBoxBagian.DisplayMember = "bagian";
            textBoxIDArt.Text = FormInputArtikelPotong.AP;
            listbagian = Bagians.BacaData("id_artikel", textBoxIDArt.Text);
            FormatDataGrid();
            TampilDataGrid();
            
        }

        private void comboBoxBagian_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Bagians selectedBagians = (Bagians)comboBoxBagian.SelectedItem;
            bool checkfill = CheckFill();
            if (checkfill == true)
            {
                string bagian = comboBoxBagian.Text.ToString();
                string kodeAp = textBoxIDArt.Text;
                int biaya = int.Parse(textBoxHarga.Text);
                listAp = ArtikelPotongs.BacaData("id", kodeAp);
                string kodeAP = listAp[0].IdArtikelPotongs.ToString();
                string brand = listAp[0].Brand.ToString();
                string kain = listAp[0].Kain.ToString();
                string seri = listAp[0].Seri.ToString();
                int yard = int.Parse(listAp[0].Yard.ToString());
                int s = int.Parse(listAp[0].Size_S.ToString());
                int m = int.Parse(listAp[0].Size_M.ToString());
                int l = int.Parse(listAp[0].Size_L.ToString());
                int xl = int.Parse(listAp[0].Size_XL.ToString());
                ArtikelPotongs ap = new ArtikelPotongs(kodeAp, brand, kain, seri, yard, s, m, l, xl);
                int ketersediaan = ArtikelPotongs.HitungTotalOrder(ap);

                Bagians b = new Bagians(bagian, ketersediaan, biaya);
                //ubah data
                Bagians.TambahData(b, kodeAp);
                listbagian = Bagians.BacaData("id_artikel", textBoxIDArt.Text);
                TampilDataGrid();
            }
            else
            {
                MessageBox.Show("Textbox cannot be Empty");
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
