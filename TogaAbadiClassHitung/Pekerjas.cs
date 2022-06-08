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
        private string nik;
        private string alamat_domisili;
        
        #endregion

        #region constructor
        public Pekerjas(int idPekerjas, string nama, string nik, string alamat_domisili)
        {
            IdPekerjas = idPekerjas;
            Nama = nama;
            Nik = nik;
            Alamat_domisili = alamat_domisili;
        }
        #endregion

        #region properties
        public string Nama { get => nama; set => nama = value; }
        public int IdPekerjas { get => idPekerjas; set => idPekerjas = value; }
        public string Nik { get => nik; set => nik = value; }
        public string Alamat_domisili { get => alamat_domisili; set => alamat_domisili = value; }
        #endregion

        #region method

        public static void TambahData(Pekerjas parPekerjas)
        {
            string sql = "INSERT INTO pekerjas(nama,nik,alamat_domisili) values ('" + parPekerjas.Nama +"','"+ parPekerjas.Nik + "','"+ parPekerjas.Alamat_domisili + "')";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static void HapusData(Pekerjas parPekerjas)
        {
            string sql = "DELETE FROM pekerjas WHERE Id='" + parPekerjas.IdPekerjas+ "'";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static void UbahData(Pekerjas parPekerjas)
        {
            string sql = "Update pekerjas set Nama='" + parPekerjas.Nama.Replace("'", "\\'") +"',nik='"+parPekerjas.Nik+"',alamat_domisili='"+parPekerjas.Alamat_domisili+ "' where id='" + parPekerjas.idPekerjas + "'";
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
                Pekerjas k = new Pekerjas(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString());
                listPekerjas.Add(k);
            }

            return listPekerjas;
        }
        #endregion
    }
}
 