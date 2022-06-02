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
    public partial class FormUbahArtPotong : Form
    {
        List<ArtikelPotongs> listap = new List<ArtikelPotongs>();
        public FormUbahArtPotong()
        {
            InitializeComponent();
        }

        private void buttonUbahBagian_Click(object sender, EventArgs e)
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

        private void buttonUbah_Click(object sender, EventArgs e)
        {

            string id = comboBoxArtikel.SelectedValue.ToString();
            string brand = textBoxBrand.Text;
            string kain = textBoxKain.Text;
            string seri = textBoxSeri.Text;
            int yard = int.Parse(textBoxYard.Text);
            int s = int.Parse(textBoxS.Text);
            int m = int.Parse(textBoxM.Text);
            int l = int.Parse(textBoxL.Text);
            int xl = int.Parse(textBoxXL.Text);
            ArtikelPotongs Ap = new ArtikelPotongs(id, brand,kain,seri,yard,s,m,l,xl);
            ArtikelPotongs.UbahData(Ap);
        }

        private void FormUbahArtPotong_Load(object sender, EventArgs e)
        {
            listap = ArtikelPotongs.BacaData("", "");
            comboBoxArtikel.DataSource = listap;
            comboBoxArtikel.DisplayMember = "idArtikelPotongs";
            FormatDataGrid();
            TampilDataGrid();
        }

        private void comboBoxArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            //listAp = ArtikelPotongs.BacaData("", "");
            string id = comboBoxArtikel.Text.ToString();
            listap = ArtikelPotongs.BacaData("id", id);

            //string kodeAP = listAp[0].IdArtikelPotongs.ToString();
            string brand = listap[0].Brand.ToString();
            string kain = listap[0].Kain.ToString();
            string seri = listap[0].Seri.ToString();
            int yard = int.Parse(listap[0].Yard.ToString());
            int s = int.Parse(listap[0].Size_S.ToString());
            int m = int.Parse(listap[0].Size_M.ToString());
            int l = int.Parse(listap[0].Size_L.ToString());
            int xl = int.Parse(listap[0].Size_XL.ToString());


            textBoxBrand.Text = brand;
            textBoxKain.Text = kain;
            textBoxSeri.Text = seri;
            textBoxYard.Text = yard.ToString();
            textBoxS.Text = s.ToString();
            textBoxM.Text = m.ToString();
            textBoxL.Text = l.ToString();
            textBoxXL.Text = xl.ToString();
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("Artikel", "Artikel");
            dataGridViewData.Columns.Add("Brand", "Brand");
            dataGridViewData.Columns.Add("Kain", "Kain");
            dataGridViewData.Columns.Add("Seri", "Seri");
            dataGridViewData.Columns.Add("Yard", "Yard Kain");
            dataGridViewData.Columns.Add("S", "Size S");
            dataGridViewData.Columns.Add("M", "Size M");
            dataGridViewData.Columns.Add("L", "Size L");
            dataGridViewData.Columns.Add("XL", "Size XL");
            dataGridViewData.Columns.Add("Jumlah", "Jumlah");

            dataGridViewData.Columns["Artikel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Brand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewData.Columns["Kain"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
        private void TampilDataGrid()
        {
            if (listap.Count > 0)
            {
                dataGridViewData.Rows.Clear();
                foreach (ArtikelPotongs ap in listap)
                {
                    int jumlahsize = ap.Size_S + ap.Size_M + ap.Size_L + ap.Size_XL;
                    dataGridViewData.Rows.Add(ap.IdArtikelPotongs,ap.Brand,ap.Kain,ap.Seri, ap.Yard, ap.Size_S, ap.Size_M, ap.Size_L, ap.Size_XL, jumlahsize);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }
    }
}
