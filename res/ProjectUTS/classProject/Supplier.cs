using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using classProject;
using MySql.Data.MySqlClient;

namespace classProject
{
    public class Supplier
    {
        #region Field
        private string kodeSupplier;
        private string nama;
        private string telepon;
        #endregion

        #region Contruction
        public Supplier(string kodeSupplier, string nama, string telepon)
        {
            KodeSupplier = kodeSupplier;
            Nama = nama;
            Telepon = telepon;
        }
        #endregion

        #region Properties
        public string KodeSupplier { get => kodeSupplier; set => kodeSupplier = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Telepon { get => telepon; set => telepon = value; }
        #endregion

        #region Method
        public static void TambahData(Supplier s)
        {
            string sql = "insert into supplier (kodeSupplier, nama, telepon) values ('" + s.KodeSupplier + "','" + s.Nama.Replace("'", "\\'") + "','" + s.Telepon + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Supplier s)
        {
            string sql = "update supplier set Nama='" + s.Nama.Replace("'", "\\'") + "', Telepon='" + s.Telepon + "' where KodeSupplier='" + s.KodeSupplier + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Supplier s)
        {
            string sql = "delete from supplier where kodeSupplier='" + s.KodeSupplier + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Supplier> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from supplier";
            }
            else
            {
                sql = "select * from supplier where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Supplier> listSupplier = new List<Supplier>();
            while (hasil.Read() == true)
            {
                Supplier s = new Supplier(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString());
                listSupplier.Add(s);
            }
            return listSupplier;
        }

        public static string GenerateKode()
        {
            string sql = "select max(KodeSupplier) from supplier";
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