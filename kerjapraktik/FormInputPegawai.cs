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
                if (filled = true)
                {
                    int id = int.Parse(textBoxId.Text);
                    string nama = textBoxNama.Text;
                    Pekerjas p = new Pekerjas(id, nama);

                    Pekerjas.TambahData(p);
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
            bool filled = false;
            if (textBoxId.Text != "" && textBoxNama.Text != "" )
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
