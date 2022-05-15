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
            Form form = Application.OpenForms["FormShowArtPotong"];
            if (form == null)
            {
                FormShowArtPotong formShowArtPotong = new FormShowArtPotong();
                formShowArtPotong.MdiParent = this;
                formShowArtPotong.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void gajiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormInputGaji"];
            if (form == null)
            {
                FormInputGaji formInputGaji = new FormInputGaji();
                formInputGaji.MdiParent = this;
                formInputGaji.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormInputPegawai"];
            if (form == null)
            {
                FormInputPegawai formInputPegawai = new FormInputPegawai();
                formInputPegawai.MdiParent = this;
                formInputPegawai.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void artikelPotongToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormUbahArtPotong"];
            if (form == null)
            {
                FormUbahArtPotong formUbahArtPotong = new FormUbahArtPotong();
                formUbahArtPotong.MdiParent = this;
                formUbahArtPotong.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pekerjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormUbahPegawai"];
            if (form == null)
            {
                FormUbahPegawai formUbahPegawai = new FormUbahPegawai();
                formUbahPegawai.MdiParent = this;
                formUbahPegawai.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void pekerjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormShowPegawai"];
            if (form == null)
            {
                FormShowPegawai formShowPegawai = new FormShowPegawai();
                formShowPegawai.MdiParent = this;
                formShowPegawai.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void gajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormShowGaji"];
            if (form == null)
            {
                FormShowGaji formShowGaji = new FormShowGaji();
                formShowGaji.MdiParent = this;
                formShowGaji.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void gajiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormUbahGaji"];
            if (form == null)
            {
                FormUbahGaji formUbahGaji = new FormUbahGaji();
                formUbahGaji.MdiParent = this;
                formUbahGaji.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
