using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TogaAbadiClassHitung
{
    public class Pekerjas
    {
        #region fields
        private int nama;
        private int idPekerjas;
        #endregion

        #region constructor
        public Pekerjas(int nama, int idPekerjas)
        {
            Nama = nama;
            IdPekerjas = idPekerjas;
        }
        #endregion

        #region properties
        public int Nama { get => nama; set => nama = value; }
        public int IdPekerjas { get => idPekerjas; set => idPekerjas = value; }
        #endregion

        #region method

        public static void TambahData(Pekerjas parPekerjas)
        {
            string sql = "INSERT INTO users(Nama) values ('" + parPekerjas.Nama +"')";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static void HapusData(Pekerjas parPekerjas)
        {
            string sql = "DELETE FROM Users WHERE IdPekerjas='" + parPekerjas.IdPekerjas+ "'";

            Koneksi.JalankanPerintahDML(sql);
        }
        #endregion
    }
}
 