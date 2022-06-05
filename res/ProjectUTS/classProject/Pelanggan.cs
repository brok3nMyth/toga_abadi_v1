using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using classProject;
using MySql.Data.MySqlClient;

namespace classProject
{
    public class Pelanggan
    {
        #region Field
        private string kodePelanggan;
        private string nama;
        private string telepon;
        #endregion

        #region Contructor
        public Pelanggan(string kodePelanggan, string nama, string telepon)
        {
            KodePelanggan = kodePelanggan;
            Nama = nama;
            Telepon = telepon;
        }
        #endregion

        #region Properties
        public string KodePelanggan { get => kodePelanggan; set => kodePelanggan = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Telepon { get => telepon; set => telepon = value; }
        #endregion

        #region Method
        public static void TambahData(Pelanggan p)
        {
            string sql = "Insert into pelanggan(KodePelanggan , Nama, Telepon) values('" + p.KodePelanggan +
                "','" + p.Nama.Replace("\\'", "'")  + "','" + p.Telepon + "')";

            Koneksi.JalankanPerintahDML(sql);

        }

        public static void UbahData(Pelanggan p)
        {
            string sql = "Update pelanggan set Nama='" + p.Nama.Replace("\\'", "'") + "', Telepon='" + p.Telepon + "' where KodePelanggan='" + p.KodePelanggan + "'";
            Koneksi.JalankanPerintahDML(sql);

            

        }

        public static void HapusData(Pelanggan p)
        {
            string sql = "Delete from Pelanggan where KodePelanggan='" + p.KodePelanggan + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Pelanggan> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "SELECT * FROM Pelanggan";
            }
            else
            {
                sql = "Select * from Pelanggan where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Pelanggan> listPelanggan = new List<Pelanggan>();
            while (hasil.Read() == true)
            {
                Pelanggan p = new Pelanggan
                    (hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString());
                listPelanggan.Add(p);

            }
            return listPelanggan;
        }
        public static string GenerateKode()
        {
            string sql = "select max(kodePelanggan) from pelanggan";
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