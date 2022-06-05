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


        private void buttonHapus_Click(object sender, EventArgs e)
        {
            Pekerjas selectedPekerjas = (Pekerjas)comboBoxPegawai.SelectedItem;
            int id = int.Parse(comboBoxPegawai.Text);
            string nama = textBoxNama.Text;
            Pekerjas p = new Pekerjas(id, nama);
            Pekerjas.HapusData(p);
            MessageBox.Show("berhasil dihapus!");
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Pekerjas selectedPekerjas = (Pekerjas)comboBoxPegawai.SelectedItem;
            int id = int.Parse(comboBoxPegawai.Text);
            string nama = textBoxNama.Text;
            Pekerjas p = new Pekerjas(id, nama);
            //ubah data
            Pekerjas.UbahData(p);
            MessageBox.Show("berhasil diubah!");
        }

        private void FormUbahPegawai_Load(object sender, EventArgs e)
        {
            listpegawai = Pekerjas.BacaData("","");

            comboBoxPegawai.DataSource = listpegawai;
            comboBoxPegawai.DisplayMember = "IdPekerjas";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Pekerjas selectedPekerjas = (Pekerjas)comboBoxPegawai.SelectedItem;
            string id = comboBoxPegawai.Text.ToString();

            listpegawai = Pekerjas.BacaData("id", id);
            string nama = listpegawai[0].Nama.ToString();
            textBoxNama.Text = nama;

            textBoxNama.Focus();
        }
    }
}
