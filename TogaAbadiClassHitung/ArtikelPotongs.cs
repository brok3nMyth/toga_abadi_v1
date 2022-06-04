using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TogaAbadiClassHitung
{
    public class ArtikelPotongs
    {
        #region fields
        private string idArtikelPotongs;
        private string brand;
        private string kain;
        private string seri;
        private int yard;
        private int size_S;
        private int size_M;
        private int size_L;
        private int size_XL;
        #endregion

        #region properties
        public string IdArtikelPotongs { get => idArtikelPotongs; set => idArtikelPotongs = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Kain { get => kain; set => kain = value; }
        public string Seri { get => seri; set => seri = value; }
        public int Yard { get => yard; set => yard = value; }
        public int Size_S { get => size_S; set => size_S = value; }
        public int Size_M { get => size_M; set => size_M = value; }
        public int Size_L { get => size_L; set => size_L = value; }
        public int Size_XL { get => size_XL; set => size_XL = value; }
        #endregion

        #region constructor
          public ArtikelPotongs(string idArtikelPotongs, string brand, string kain, string seri, int yard, int size_S, int size_M, int size_L, int size_XL)
        {
            IdArtikelPotongs = idArtikelPotongs;
            Brand = brand;
            Kain = kain;
            Seri = seri;
            Yard = yard;
            Size_S = size_S;
            Size_M = size_M;
            Size_L = size_L;
            Size_XL = size_XL;
        }
        #endregion

        #region method
        public static void TambahData(ArtikelPotongs ap)
        {
            string sql = "Insert into artikelPotongs(id , brand, kain, seri, yard, size_s, size_m, size_L,size_xl) values('"
                + ap.IdArtikelPotongs +
                "','" + ap.Brand + "','" + ap.Kain + "','" + ap.Seri + "','" + ap.Yard + "','" + ap.Size_S + "','" + ap.Size_M + "','" + ap.Size_L + "','" + ap.Size_XL + "')";

            Koneksi.JalankanPerintahDML(sql);

        }

        public static void UbahData(ArtikelPotongs ap)
        {
            string sql = "Update artikelPotongs set Brand='" + ap.Brand + "',kain= '" + ap.Kain+
                "', seri ='" + ap.Seri + "', yard='" + ap.Yard+ "',size_s ='" + ap.Size_S+ "',size_m ='" 
                + ap.Size_M + "',size_l ='" + ap.Size_L + "',size_xl ='" + ap.Size_XL +
                "' where id='" + ap.IdArtikelPotongs + "'";
            Koneksi.JalankanPerintahDML(sql);



        }

        public static void HapusData(ArtikelPotongs ap)
        {
            string sql = "Delete from artikelPotongs where i='" + ap.idArtikelPotongs + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<ArtikelPotongs> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "SELECT * FROM artikelpotongs";
            }
            else
            {
                sql = "Select * from artikelpotongs where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<ArtikelPotongs> listArtikelPotongs = new List<ArtikelPotongs>();
            while (hasil.Read() == true)
            {
                ArtikelPotongs ap = new ArtikelPotongs(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), 
                    int.Parse(hasil.GetValue(4).ToString()), int.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()),
                    int.Parse(hasil.GetValue(7).ToString()), int.Parse(hasil.GetValue(8).ToString()));
                listArtikelPotongs.Add(ap);

            }
            return listArtikelPotongs;
        }

        public static string GenerateKode(string kode)
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            string hasilKode1 = kode +"-"+ date.Replace("/", "-");// L001-11-05-22 05:02:50
            string hasilKode2 = hasilKode1.Replace(":", "-");// L001-11-05-22 05-02-50
            string hasilKode3 = hasilKode2.Replace(" ", "-");// L001-11-05-22-05-02-50
            return hasilKode3;
        }

        public static int HitungTotalOrder(ArtikelPotongs ap)
        {
            int total = ap.Size_S + ap.Size_M + ap.Size_L + ap.Size_XL;
            return total;
        }
        #endregion
    }
}