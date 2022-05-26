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
        List<ArtikelPotongs> listAp = new List<ArtikelPotongs>();
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

        private void comboBoxArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            listAp = ArtikelPotongs.BacaData("", "");
            string id = comboBoxArtikel.SelectedValue.ToString();
            listAp = ArtikelPotongs.BacaData("idArtikelPotongs", id);

            string kodeAP = listAp[0].IdArtikelPotongs.ToString();
            string brand = listAp[0].Brand.ToString();
            string kain = listAp[0].Kain.ToString();
            string seri = listAp[0].Seri.ToString();
            int yard = int.Parse(listAp[0].Yard.ToString());
            int s = int.Parse(listAp[0].Size_S.ToString());
            int m = int.Parse(listAp[0].Size_M.ToString());
            int l = int.Parse(listAp[0].Size_L.ToString());
            int xl = int.Parse(listAp[0].Size_XL.ToString());

            
            textBoxBrand.Text = brand;
            textBoxKain.Text = kain;
            textBoxSeri.Text = seri;
            textBoxYard.Text = yard.ToString();
            textBoxS.Text = s.ToString();
            textBoxM.Text = m.ToString();
            textBoxL.Text = l.ToString();
            textBoxXL.Text = xl.ToString();



        }

        private void FormUbahArtPotong_Load(object sender, EventArgs e)
        {
            listAp = ArtikelPotongs.BacaData("", "");
            comboBoxArtikel.DataSource = listAp;
            comboBoxArtikel.DisplayMember = "id";
        }
    }
}
