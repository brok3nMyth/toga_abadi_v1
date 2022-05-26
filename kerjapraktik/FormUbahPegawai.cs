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
    public partial class FormUbahPegawai : Form
    {
        List<Pekerjas> listpegawai = new List<Pekerjas>();
        public FormUbahPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            Pekerjas selectedPekerjas = (Pekerjas)comboBoxPegawai.SelectedItem;
            int id = int.Parse(comboBoxPegawai.SelectedValue.ToString());
            string nama = textBoxNama.Text;
            Pekerjas p = new Pekerjas(id, nama);
            Pekerjas.HapusData(p);
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Pekerjas selectedPekerjas = (Pekerjas)comboBoxPegawai.SelectedItem;
            int id = int.Parse(comboBoxPegawai.SelectedValue.ToString());
            string nama = listpegawai[0].Nama.ToString();
            Pekerjas p = new Pekerjas(id, nama);
            //ubah data
            Pekerjas.UbahData(p);
        }

        private void FormUbahPegawai_Load(object sender, EventArgs e)
        {
            listpegawai = Pekerjas.BacaData("","");

            comboBoxPegawai.DataSource = listpegawai;
            comboBoxPegawai.DisplayMember = "IdPekerjas";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pekerjas selectedPekerjas= (Pekerjas)comboBoxPegawai.SelectedItem;
            string id = comboBoxPegawai.SelectedValue.ToString();

            listpegawai = Pekerjas.BacaData("idPekerjas", id );
            string nama = listpegawai[0].Nama.ToString();
            textBoxNama.Text = nama;

            textBoxNama.Focus();
        }
    }
}
