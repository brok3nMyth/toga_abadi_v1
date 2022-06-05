using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using classProject;
using MySql.Data.MySqlClient;

namespace classProject
{
    public class JenisBarang
    {
        #region Fields
        private string kodeJenisBarang;
        private string nama;
        #endregion

        #region Constructor
        public JenisBarang(string kodeJenisBarang, string nama)
        {
            KodeJenisBarang = kodeJenisBarang;
            Nama = nama;
        }
        #endregion

        #region Properties
        public string KodeJenisBarang { get => kodeJenisBarang; set => kodeJenisBarang = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Method
        public static void TambahData(JenisBarang j)
        {
            string sql = "Insert into jenisbarang(KodeJenisBarang, Nama) values('" + j.KodeJenisBarang + "','" + j.Nama.Replace("'", "\\'") + "')";

            Koneksi.JalankanPerintahDML(sql);

        }

        public static void UbahData(JenisBarang j)
        {
            string sql = "Update JenisBarang set Nama='" + j.Nama.Replace("'", "\\'") + "' where KodeJenisBarang='" + j.KodeJenisBarang + "'";
            Koneksi.JalankanPerintahDML(sql);



        }

        public static void HapusData(JenisBarang j)
        {
            string sql = "Delete from jenisbarang where KodeJenisBarang='" + j.KodeJenisBarang+ "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<JenisBarang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "SELECT * FROM JenisBarang";
            }
            else
            {
                sql = "Select * from JenisBarang where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<JenisBarang> listJenisBarang = new List<JenisBarang>();
            while (hasil.Read() == true)
            {
                JenisBarang j = new JenisBarang(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString());
                listJenisBarang.Add(j);

            }
            return listJenisBarang;
        }
        public static string GenerateKode()
        {
            string sql = "select max(kodeJenisBarang) from JenisBarang";
            string hasilKode = "";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                int kodeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;

                hasilKode = kodeTerbaru.ToString().PadLeft(2, '0');
            }
            else
            {
                hasilKode = "01";
            }
            return hasilKode;
        }
        #endregion
    }
}