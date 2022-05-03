﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TogaAbadiClassHitung
{
    public class Users
    {
        #region fields
        private int username;
        private int password;
        private int isAdmin;
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

        public Users(int username, int password, int isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
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
        #endregion
    }
}