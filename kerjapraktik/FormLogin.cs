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
        //List<Users> listusers = new List<Users>();
        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi k = new Koneksi("localhost", "toga_abadi_v1", "root", ""); // "superadmin", "WXWdh41aYBKzi15R"); //'root','' 
                Koneksi k2 = new Koneksi();

                MessageBox.Show("Koneksi berhasil","Informasi");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Connection failed. Error message : " + exc.Message);
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
                {
                    //Users u = new Users(textBoxUsername.Text, textBoxPassword.Text);
                    string status = Users.Login(textBoxUsername.Text, textBoxPassword.Text);
                    if (status == "login")
                    {
                        MessageBox.Show("Connection successful. You can now use the program");

                        FormMenu formMain = (FormMenu)this.Owner;
                        formMain.Enabled = true;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username and Password incorrect");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Username and Password cannot be empty");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Connection failed. Error message : " + exc.Message);
            }
        }
    }
}
