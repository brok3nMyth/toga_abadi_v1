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
        //public ICollection<Pekerjas> Pekerjas { get; set; }
        #endregion

        #region constructor
        

        public Users(string username, string password)
        {
            Username = username;
            Password = password;
        }
        #endregion

        #region properties
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region method
        public static void TambahData(Users parUsers)
        {
            string sql = "INSERT INTO users(Username, Password) values ('" + parUsers.Username + "', '" + parUsers.Password + "')";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static void HapusData(Users parUsers)
        {
            string sql = "DELETE FROM Users WHERE Username='" + parUsers.Username + "'";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static string Login(string parUsername, string parPassword)
        {
            string sql = "select password from users where username like '" + parUsername+"'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            hasil.Read();
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