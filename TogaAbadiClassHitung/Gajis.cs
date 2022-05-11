using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TogaAbadiClassHitung
{
    public class Gajis
    {
        #region fields
        private int idGaji;
        private int diambil;
        private int subtotal;
        private int sisaKasbon;
        private int kasbon;
        private int totalKasbon;
        private int potonganKasbon;
        private int totalGaji;
        private Pekerjas pekerjas;
        private Bagians bagians;




        #endregion
        #region constructor
        public Gajis(int idGaji, int diambil, int subtotal, int sisaKasbon, int kasbon, int totalKasbon, int potonganKasbon, int totalGaji)
        {
            IdGaji = idGaji;
            Diambil = diambil;
            Subtotal = subtotal;
            SisaKasbon = sisaKasbon;
            Kasbon = kasbon;
            TotalKasbon = totalKasbon;
            PotonganKasbon = potonganKasbon;
            TotalGaji = totalGaji;
        }
        public Pekerjas Pekerjas
        {
            get => default(Pekerjas);
            set
            {
            }
        }

        public Bagians Bagians
        {
            get => default(Bagians);
            set
            {
            }
        }
        #endregion
        #region properties
        public int IdGaji { get => idGaji; set => idGaji = value; }
        public int Diambil { get => diambil; set => diambil = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }
        public int SisaKasbon { get => sisaKasbon; set => sisaKasbon = value; }
        public int Kasbon { get => kasbon; set => kasbon = value; }
        public int TotalKasbon { get => totalKasbon; set => totalKasbon = value; }
        public int PotonganKasbon { get => potonganKasbon; set => potonganKasbon = value; }
        public int TotalGaji { get => totalGaji; set => totalGaji = value; }
        #endregion

        #region method
        public static void TambahData(Bagians parBagians)
        {
            string sql = "INSERT INTO Bagians(Bagians, Tersedia, biaya_Satuan) values ('" + parBagians.Bagian + "', '" + parBagians.Tersedia + "', '" + parBagians.Biaya_Satuan + "')";

            Koneksi.JalankanPerintahDML(sql);
        }
        //ubah data
        public static void HapusData(Bagians parBagians)
        {
            string sql = "DELETE FROM Bagians WHERE Username='" + parBagians.IdBagians + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        //lihat data 

        public static List<Bagians> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                //sql = "select B.idBagians, B.id_artikel, B.bagian, B.tersedia, B.biaya_satuan from Bagians B ";
                sql = "select B.id, B.id_artikel, B.bagian, B.tersedia, B.biaya_satuan,  ap.brand, ap.kain, ap.seri, ap.yard, ap.size_S, ap.size_M, ap.size_L, ap.size_XL " +
                    "from Bagians B inner join ArtikelPotongs ap on B.id_artikel = ap.id";
            }
            else
            {
                sql = "select B.id, B.id_artikel, B.bagian, B.tersedia, B.biaya_satuan,  ap.brand, ap.kain, ap.seri, ap.yard, ap.size_S, ap.size_M, ap.size_L, ap.size_XL " +
                    "from Bagians B inner join ArtikelPotongs ap on B.id_artikel = ap.id where " + kriteria + " LIKE '%" +
                    nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Bagians> listBagians = new List<Bagians>();
            while (hasil.Read() == true)
            {
                ArtikelPotongs artikel = new ArtikelPotongs(hasil.GetValue(1).ToString(), hasil.GetValue(5).ToString(), hasil.GetValue(6).ToString(), hasil.GetValue(7).ToString(), int.Parse(hasil.GetValue(8).ToString()), int.Parse(hasil.GetValue(9).ToString()), int.Parse(hasil.GetValue(10).ToString()), int.Parse(hasil.GetValue(11).ToString()), int.Parse(hasil.GetValue(12).ToString()));

                Bagians b = new Bagians(int.Parse(hasil.GetValue(0).ToString()), artikel, hasil.GetValue(2).ToString(), int.Parse(hasil.GetValue(3).ToString()),
                    int.Parse(hasil.GetValue(4).ToString()));

                listBagians.Add(b);
            }
            return listBagians;
        }
        #endregion
    }
}