using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TogaAbadiClassHitung
{
    public class ArtikelPotongs
    {
        private string idArtikelPotongs;
        private string brand;
        private string kain;
        private string seri;
        private int yard;
        private int size_S;
        private int size_M;
        private int size_L;
        private int size_XL;

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

        public string IdArtikelPotongs { get => idArtikelPotongs; set => idArtikelPotongs = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Kain { get => kain; set => kain = value; }
        public string Seri { get => seri; set => seri = value; }
        public int Yard { get => yard; set => yard = value; }
        public int Size_S { get => size_S; set => size_S = value; }
        public int Size_M { get => size_M; set => size_M = value; }
        public int Size_L { get => size_L; set => size_L = value; }
        public int Size_XL { get => size_XL; set => size_XL = value; }


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
                ArtikelPotongs aP = new ArtikelPotongs(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), 
                    int.Parse(hasil.GetValue(4).ToString()), int.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()),
                    int.Parse(hasil.GetValue(7).ToString()), int.Parse(hasil.GetValue(8).ToString()));
                listArtikelPotongs.Add(aP);

            }
            return listArtikelPotongs;
        }
    }
}