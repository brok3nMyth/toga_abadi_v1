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
        private int username;
        private int password;
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

        public Users(int username, int password, int isAdmin, Pekerjas pekerjas)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
            Pekerjas = pekerjas;
        }
        #endregion

        #region properties
        public int Username { get => username; set => username = value; }
        public int Password { get => password; set => password = value; }
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
        public static string Login(Users parUsername, Users parPassword)
        {
            string sql = "select password from users where username like " + parUsername;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string pass = hasil.GetValue(0).ToString();

            string status = "";

            if (Equals(pass,parPassword))
            {
                status = "login";
                
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