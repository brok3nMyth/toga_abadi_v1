using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TogaAbadiClassHitung
{
    public class Users
    {
        #region fields
        private string username;
        private string password;
        private int isAdmin;
        private Pekerjas pekerjas;
        //public ICollection<Pekerjas> Pekerjas { get; set; }
        #endregion

        #region constructor
        public Pekerjas Pekerjas
        {
            get => default(Pekerjas);
            set
            {
            }
        }

        public Users(string username, string password, int isAdmin, Pekerjas pekerjas)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
            Pekerjas = pekerjas;
        }
        public Users(string username, string password)
        {
            Username = username;
            Password = password;
        }
        #endregion

        #region properties
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int IsAdmin { get => isAdmin; set => isAdmin = value; }
        #endregion

        #region method
        public static void TambahData(Users parUsers)
        {
            string sql = "INSERT INTO users(Username, Password, isAdmin) values ('" + parUsers.Username + "', '" + parUsers.Password + "', '" + parUsers.isAdmin + "', '" + parUsers.Pekerjas + "')";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static void HapusData(Users parUsers)
        {
            string sql = "DELETE FROM Users WHERE Username='" + parUsers.Username + "'";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static string Login(string parUsername, string parPassword)
        {
            string sql = "select password,isAdmin from users where username like '" + parUsername+"'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            hasil.Read();
            string pass = hasil.GetValue(0).ToString();
            
            string status = "";

            if (Equals(pass,parPassword))
            {
                int isAdmin = int.Parse(hasil.GetValue(1).ToString());
                if (isAdmin == 1)
                {
                    status = "login";
                }
                else
                {
                    status = "login"; //nanti buat separasi UI antara user dan admin
                }
                
                
            }
            else
            {
                status = "fail";
            }
            return status;
        }
        #endregion
    }
}