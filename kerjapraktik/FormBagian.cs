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

        private void FormBagian_Load(object sender, EventArgs e)
        {
            listbagian = Bagians.BacaData("", "");

            comboBoxBagian.DataSource = listbagian;
            comboBoxBagian.DisplayMember = "bagian";
        }

        private void comboBoxBagian_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bagians selectedBagians = (Bagians)comboBoxBagian.SelectedItem;
            string id = comboBoxBagian.SelectedValue.ToString();

            //listbagian = Bagians.BacaData("idBagians", id);
           // string nama = listbagian[0].Nama.ToString();
            //textBoxNama.Text = nama;

            //textBoxNama.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           // Bagians selectedBagians = (Bagians)comboBoxBagian.SelectedItem;
           // int id = int.Parse(comboBoxBagian.SelectedValue.ToString());
           //string nama = listBagian[0].Nama.ToString();
            //Bagians p = new Bagians(id, nama);
            //ubah data
            //Bagians.TambahData(p);
        }
    }
}
