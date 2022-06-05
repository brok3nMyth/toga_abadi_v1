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

namespace ProjectUTS
{
    public partial class FormSettings : Form
    {
        public static string server;
        public static string database;

        public FormSettings()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void textBoxServer_Enter(object sender, EventArgs e)
        {
            if (textBoxServer.Text == "Server")
            {
                textBoxServer.Text = "";

                textBoxServer.ForeColor = Color.Black;
            }
        }

        private void textBoxServer_Leave(object sender, EventArgs e)
        {
            if (textBoxServer.Text == "")
            {
                textBoxServer.Text = "Server";

                textBoxServer.ForeColor = Color.Silver;
            }
        }

        private void textBoxDB_Enter(object sender, EventArgs e)
        {
            if (textBoxDB.Text == "Database")
            {
                textBoxDB.Text = "";

                textBoxDB.ForeColor = Color.Black;
            }
        }

        private void textBoxDB_Leave(object sender, EventArgs e)
        {
            if (textBoxServer.Text == "")
            {
                textBoxServer.Text = "Database";

                textBoxServer.ForeColor = Color.Silver;
            }
        }

        private void pictureBoxCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBorder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
