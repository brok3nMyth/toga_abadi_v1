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


        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            Pekerjas selectedPekerjas = (Pekerjas)comboBoxPegawai.SelectedItem;
            int id = int.Parse(comboBoxPegawai.Text);
            string nama = textBoxNama.Text;
            string nik = textBoxNIK.Text;
            string domisili = textBoxDomisili.Text;
            var isNumeric = int.TryParse(nik, out _);
            if (isNumeric == true)
            {
                Pekerjas p = new Pekerjas(id, nama, nik, domisili);

                Pekerjas.TambahData(p);
                MessageBox.Show("berhasil diubah!");
            }
            MessageBox.Show("NIK hanya boleh berisi angka");
            
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
            string nik = listpegawai[0].Nik.ToString();
            string alamat = listpegawai[0].Alamat_domisili.ToString();

            textBoxNama.Text = nama;
            textBoxNIK.Text = nik;
            textBoxDomisili.Text = alamat;

            textBoxNama.Focus();
        }

        private void textBoxDomisili_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
