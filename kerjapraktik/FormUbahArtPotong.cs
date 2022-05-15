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
    public partial class FormUbahArtPotong : Form
    {
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
    }
}
