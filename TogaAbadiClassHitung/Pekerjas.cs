using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TogaAbadiClassHitung
{
    public class Pekerjas
    {
        #region fields
        private int idPekerjas;
        private string nama;
        
        #endregion

        #region constructor
        public Pekerjas(int idPekerjas, string nama)
        {
            IdPekerjas = idPekerjas;
            Nama = nama;
            
        }
        #endregion

        #region properties
        public string Nama { get => nama; set => nama = value; }
        public int IdPekerjas { get => idPekerjas; set => idPekerjas = value; }
        #endregion

        #region method

        public static void TambahData(Pekerjas parPekerjas)
        {
            string sql = "INSERT INTO pekerjas(Nama) values ('" + parPekerjas.Nama +"')";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static void HapusData(Pekerjas parPekerjas)
        {
            string sql = "DELETE FROM pekerjas WHERE IdPekerjas='" + parPekerjas.IdPekerjas+ "'";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static void UbahData(Pekerjas parPekerjas)
        {
            string sql = "Update pekerjas set Nama='" + parPekerjas.Nama.Replace("'", "\\'") + "' where id='" + parPekerjas.idPekerjas + "'";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static List<Pekerjas> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from Pekerjas";
            }
            else
            {
                sql = "select * from Pekerjas where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Pekerjas> listPekerjas = new List<Pekerjas>();
            while (hasil.Read() == true)
            {
                Pekerjas k = new Pekerjas(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString());
                listPekerjas.Add(k);
            }

            return listPekerjas;
        }
        #endregion
    }
}
 