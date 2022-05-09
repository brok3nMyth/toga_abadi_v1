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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void artikelPotongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormInputArtikelPotong"];
            if (form == null)
            {
                FormInputArtikelPotong formInputArtikelPotong = new FormInputArtikelPotong();
                formInputArtikelPotong.MdiParent = this;
                formInputArtikelPotong.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void artikelPotongToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
