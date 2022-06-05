using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace classProject
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Contructor
        public Koneksi()
        {
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;
            this.Connect();
        }

        public Koneksi(string namaServer, string namaDb, string username, string pass)
        {
            string strCon = "";
            if (pass != "")
            {
                strCon = "Server=" + namaServer + ";Database=" + namaDb + ";Uid=" + username + ";Pwd=" + pass + ";Pooling=false;Connect Timeout=45;";
            }
            else
            {
                strCon = "Server=" + namaServer + ";Database=" + namaDb + ";Uid=" + username + ";";
            }

            this.KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = strCon;
            this.Connect();
            UpdateAppConfig(strCon);
        }
        #endregion

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region Methods
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }
        public void UpdateAppConfig(string con)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["namakoneksi"].ConnectionString = con;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static void JalankanPerintahDML(string pSql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(pSql, k.KoneksiDB);
            c.ExecuteNonQuery();
            k.Connect();
        }
        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }
        public static string GetNamaServer()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            return con.DataSource;
        }
        public static string GetNamaDatabase()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            return con.Database;
        }

        #endregion

    }
}
