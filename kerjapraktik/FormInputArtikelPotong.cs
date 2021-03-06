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
    public partial class FormInputArtikelPotong : Form
    {
        public FormInputArtikelPotong()
        {
            InitializeComponent();
        }
        List<ArtikelPotongs> listap = new List<ArtikelPotongs>();
        public static string AP = "";
        private void buttonTambahBagian_Click(object sender, EventArgs e)
        {
            AP = textBoxKodeArtikel.Text;
            if (AP == "")
            {
                MessageBox.Show("Isi kode AP dulu!", "Peringatan");
            }
            else
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
        }
        private void TampilDataGrid()
        {
            if (listap.Count > 0)
            {
                dataGridViewData.Rows.Clear();
                foreach (ArtikelPotongs ap in listap)
                {
                    int jumlahsize = ap.Size_S + ap.Size_M + ap.Size_L + ap.Size_XL;
                    dataGridViewData.Rows.Add(ap.Seri,ap.Yard,ap.Size_S,ap.Size_M,ap.Size_L,ap.Size_XL,jumlahsize);
                }
            }
            else
            {
                dataGridViewData.DataSource = null;
            }
        }
        private void FormInputArtikelPotong_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            textBoxYard.Text = "0";
            textBoxS.Text = "0";
            textBoxM.Text = "0";
            textBoxL.Text = "0";
            textBoxXL.Text = "0";
        }
        private void FormatDataGrid()
        {
            dataGridViewData.Columns.Clear();

            dataGridViewData.Columns.Add("Seri", "Seri");
            dataGridViewData.Columns.Add("Yard", "Yard Kain");
            dataGridViewData.Columns.Add("S", "Size S");
            dataGridViewData.Columns.Add("M", "Size M");
            dataGridViewData.Columns.Add("L", "Size L");
            dataGridViewData.Columns.Add("XL", "Size XL");
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
            try
            {
                bool filled = CheckFill();
                if (filled == true)
                {
                    string kodeAP =  ArtikelPotongs.GenerateKode(textBoxKodeArtikel.Text);
                    string brand = textBoxBrand.Text;
                    string kain = textBoxKain.Text;
                    string seri = textBoxSeri.Text;
                    int yard = int.Parse(textBoxYard.Text);
                    int s = int.Parse(textBoxS.Text);
                    int m = int.Parse(textBoxM.Text);
                    int l = int.Parse(textBoxL.Text);
                    int xl = int.Parse(textBoxXL.Text);
                    ArtikelPotongs ap = new ArtikelPotongs(kodeAP,brand,kain,seri,yard,s,m,l,xl);

                    ArtikelPotongs.TambahData(ap);
                    Clear();

                    listap = ArtikelPotongs.BacaData("id", textBoxKodeArtikel.Text);

                    TampilDataGrid();

                }
                else
                {
                    MessageBox.Show("Textbox cannot be Empty");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private bool CheckFill()
        {
            bool filled= false;
            if (textBoxKodeArtikel.Text !=""&& textBoxBrand.Text !="" && textBoxKain.Text !="" &&textBoxSeri.Text !="")
            {
                filled = true;
            }
            return filled;
        }
        private void Clear()
        {
            textBoxSeri.Clear();
            textBoxYard.Clear();
            textBoxS.Clear();
            textBoxM.Clear();
            textBoxL.Clear();
            textBoxXL.Clear();
        }
        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
