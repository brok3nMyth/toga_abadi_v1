using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TogaAbadiClassHitung
{
    public class Bagians
    {
        #region fields 
        private int idBagians;
        private string bagian;
        private int tersedia;
        private int biaya_Satuan;
        private ArtikelPotongs artikelPotongs;
        #endregion

        #region constructor
        public Bagians(int idBagians,ArtikelPotongs artikelPotongs, string bagian, int tersedia, int biaya_Satuan)
        {
            IdBagians = idBagians;
            ArtikelPotongs = artikelPotongs;
            Bagian = bagian;
            Tersedia = tersedia;
            Biaya_Satuan = biaya_Satuan;
        }
        public Bagians(int idBagians, string bagian, int tersedia, int biaya_Satuan)
        {
            IdBagians = idBagians;
            Bagian = bagian;
            Tersedia = tersedia;
            Biaya_Satuan = biaya_Satuan;
        }
        public Bagians( string bagian, int tersedia, int biaya_Satuan)
        {
            Bagian = bagian;
            Tersedia = tersedia;
            Biaya_Satuan = biaya_Satuan;
        }

        #endregion

        #region properties
        public int IdBagians { get => idBagians; set => idBagians = value; }
        public string Bagian { get => bagian; set => bagian = value; }
        public int Tersedia { get => tersedia; set => tersedia = value; }
        public int Biaya_Satuan { get => biaya_Satuan; set => biaya_Satuan = value; }
        public ArtikelPotongs ArtikelPotongs { get => artikelPotongs; set => artikelPotongs = value; }

        #endregion

        #region method
        public static void TambahData(Bagians parBagians, string kodeAp)
        {

            List<ArtikelPotongs> listAP = ArtikelPotongs.BacaData("id", kodeAp);

            string kodeAPreal = listAP[0].IdArtikelPotongs.ToString();

            string sql = "INSERT INTO Bagians(id_artikel, bagian, Tersedia, biaya_Satuan) values ('"+kodeAPreal+"','"+ parBagians.Bagian+ "', '" + parBagians.Tersedia+ "', '" + parBagians.Biaya_Satuan+ "')";

            Koneksi.JalankanPerintahDML(sql);
        }
        //ubah data
        public static void UbahData(Bagians parBagians, string kodeAP)
        {
            string sql = "Update Bagians set Tersedia='" + parBagians.Tersedia + "',biaya_satuan= '" + parBagians.biaya_Satuan +
                "' where id_artikel ='" + kodeAP + "' AND bagian LIKE '%"+parBagians.Bagian+"%'";


            Koneksi.JalankanPerintahDML(sql);
        }
        public static void UbahDataId(Bagians parBagians)
        { 
            string sql = "Update Bagians set Tersedia='" + parBagians.Tersedia + "',biaya_satuan= '" + parBagians.biaya_Satuan +
                "' where id ='" + parBagians.idBagians+ "'";


            Koneksi.JalankanPerintahDML(sql);
        }
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
        public static List<Bagians> BacaData2(string parbagian, string parkodeap)
        {
            
               string sql = "select B.id, B.id_artikel, B.bagian, B.tersedia, B.biaya_satuan,  ap.brand, ap.kain, ap.seri, ap.yard, ap.size_S, ap.size_M, ap.size_L, ap.size_XL " +
                    "from Bagians B inner join ArtikelPotongs ap on B.id_artikel = ap.id where b.bagian LIKE '%" + parbagian + "%' AND b.id_artikel LIKE '%" +
                    parkodeap + "%'";
            
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
