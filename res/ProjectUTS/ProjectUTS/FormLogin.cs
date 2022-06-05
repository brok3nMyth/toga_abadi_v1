using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classProject;

namespace ProjectUTS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region UI Settings
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text=="Username")
            {
                textBoxUsername.Text = "";

                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";

                textBoxUsername.ForeColor = Color.Silver;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text=="Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.PasswordChar = '*';
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";

                textBoxPassword.ForeColor = Color.Silver;
            }
        }

        private void panelBorder_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            this.Height = panelLogin.Height + panelSettings.Height;
        }


        private void pictureBoxCls_Click(object sender, EventArgs e)
        {
            this.Height = panelLogin.Height;
        }
        #endregion
        private void pictureBoxBtnSimpan_Click(object sender, EventArgs e)
        {
            this.Height = panelLogin.Height;
            if (textBoxServer.Text != "" && textBoxDB.Text != "")
            {
                MessageBox.Show("Server and database change has been saved", "Message");
            }
            else
            {
                MessageBox.Show("Server name and database cannot be empty", "Warning");
            }

        }

        private void pictureBoxBtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != "")
                {
                    Koneksi k = new Koneksi(textBoxServer.Text, textBoxDB.Text, textBoxUsername.Text, textBoxPassword.Text);
                    Koneksi k2 = new Koneksi();

                    MessageBox.Show("Connection successful. You can now use the program");

                    FormUtama formMain = (FormUtama)this.Owner;
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxServer.Text = "localhost";
            textBoxDB.Text = "database_toko";

            this.Height = panelLogin.Height;
        }

    }
}
