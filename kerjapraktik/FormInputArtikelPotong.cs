using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kerjapraktik
{
    public partial class FormInputArtikelPotong : Form
    {
        public FormInputArtikelPotong()
        {
            InitializeComponent();
        }

        private void buttonTambahBagian_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormBagian"];
            if (form == null)
            {
                FormBagian formBagian = new FormBagian();
                formBagian.MdiParent = this;
                formBagian.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
