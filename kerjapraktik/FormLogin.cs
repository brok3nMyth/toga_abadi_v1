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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != "")
                {
                    Koneksi k = new Koneksi("localhost", "db", textBoxUsername.Text, textBoxPassword.Text);
                    Koneksi k2 = new Koneksi();

                    MessageBox.Show("Connection successful. You can now use the program");

                    FormMenu formMain = (FormMenu)this.Owner;
                    formMain.Enabled = true;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username cannot be empty");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Connection failed. Error message : " + exc.Message);
            }
        }
    }
}
