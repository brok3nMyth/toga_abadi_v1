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
    public partial class FormInputPegawai : Form
    {
        public FormInputPegawai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                bool filled = CheckFill();
                if (filled == true)
                {
                    int id = 0;//ai
                    string nama = textBoxNama.Text;
                    string nik = textBoxNIK.Text;
                    string domisili = textBoxDomisili.Text;
                    if (nik.Length == 16)
                    {
                        var isNumeric = long.TryParse(nik, out _);
                        if (isNumeric == true)
                        {
                            Pekerjas p = new Pekerjas(id, nama, nik, domisili);

                            Pekerjas.TambahData(p);
                            MessageBox.Show("Tambah data pegawai berhasil");
                        }
                        else
                        {
                            MessageBox.Show("NIK hanya boleh berisi angka");
                        }
                    }
                    else
                    {
                        MessageBox.Show("NIK harus terdiri dari 16 digit");
                    }
                    
                    

                }
                else
                {
                    MessageBox.Show("Semua kolom harus terisi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("message : " + ex);
            }
        }
        private bool CheckFill()
        {
            bool filled = false;
            if (textBoxNama.Text != "" &&textBoxNIK.Text!=""&&textBoxDomisili.Text!="")
            {
                filled = true;
            }
            return filled;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
