using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TogaAbadiClassHitung
{
    public class Terambils
    {
        #region fields
        private Gajis gajis;
        private Bagians bagians;
        private int diambil;

        //

        string kodeAp;
        string seri;
        string bagian; 
        int satuan;

        #endregion

        #region constructor
        public Terambils(Gajis gajis, Bagians bagians, int diambil)
        {
            Gajis = gajis;
            Bagians = bagians;
            Diambil = diambil;
        }
        
        public Terambils(string kodeAp, string seri, string bagian, int diambil, int satuan)
        {
            KodeAp = kodeAp;
            Seri = seri;
            Bagian = bagian;
            Diambil = diambil;
            Satuan = satuan;
        }
        #endregion

        #region properties
        public Bagians Bagians
        {
            get => default(Bagians);
            set
            {
            }
        }
        public Gajis Gajis
        {
            get => default(Gajis);
            set
            {
            }
        }
        public int Diambil { get => diambil; set => diambil = value; }
        public string KodeAp { get => kodeAp; set => kodeAp = value; }
        public string Seri { get => seri; set => seri = value; }
        public string Bagian { get => bagian; set => bagian = value; }
        public int Satuan { get => satuan; set => satuan = value; }
        #endregion

        #region method
        public static void TambahData(Terambils parTerambils,Gajis parGajis, Bagians parBagians)
        {

            //string sql2 = "select SCOPE_IDENTITY()";
            string sql2 = "SELECT id FROM `gajis` ORDER BY id DESC LIMIT 1";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql2);
            hasil.Read();
            int id = int.Parse(hasil.GetValue(0).ToString());

            string sql = "INSERT INTO Terambils(bagians_id, gajis_id, diambil) values ('"
                + parBagians.IdBagians + "', '" + id + "', '"  + parTerambils.Diambil +"')";

            
            Koneksi.JalankanPerintahDML(sql);
        }
        //ubah data
        public static void HapusData(Terambils parTerambils)
        {
            string sql = "DELETE FROM Gajis WHERE gajis_id='" + parTerambils.Gajis.IdGaji + 
                "' AND bagiand_id='"+ parTerambils.Bagians.IdBagians+"'";

            Koneksi.JalankanPerintahDML(sql);
        }

        //lihat data 

        public static List<Terambils> BacaData(string kriteria, string nilaiKriteria,string kodeAP)
        {
            string sql = "";
            //ambil id gaji
            string sql2 = "SELECT id FROM `gajis` ORDER BY id DESC LIMIT 1";
            MySqlDataReader hasil2 = Koneksi.JalankanPerintahQuery(sql2);
            hasil2.Read();
            int idGajis = int.Parse(hasil2.GetValue(0).ToString());

            if (kriteria == "")
            {
                //sql = "select B.idBagians, B.id_artikel, B.bagian, B.tersedia, B.biaya_satuan from Bagians B ";
                sql = "SELECT * FROM terambils t " +
                        "LEFT JOIN bagians b on b.id = t.bagians_id " + 
                        "LEFT JOIN gajis g on g.id = t.gajis_id";
                //"SELECT * FROM gajis g " +"LEFT JOIN bagians b on g.models_id = b.id" +"LEFT JOIN artikelpotongs ap on ap.id = b.id_artikel";
            }
            else
            {
                sql = "SELECT* FROM terambils t " +
                        "LEFT JOIN bagians b on b.id = t.bagians_id " +
                        "LEFT JOIN gajis g on g.id = t.gajis_id WHERE "
                        + kriteria + " LIKE '%" + idGajis + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

           
            List<Terambils> listTerambils = new List<Terambils>();
            while (hasil.Read() == true)
            {
                List<Pekerjas> listp = Pekerjas.BacaData("id", hasil.GetValue(9).ToString());
                Pekerjas p = new Pekerjas(listp[0].IdPekerjas,listp[0].Nama);

                Gajis g = new Gajis(int.Parse(hasil.GetValue(8).ToString()), hasil.GetValue(10).ToString(), int.Parse(hasil.GetValue(12).ToString()), int.Parse(hasil.GetValue(13).ToString()),
                    int.Parse(hasil.GetValue(14).ToString()), p.Nama);
                List<ArtikelPotongs> listAp = ArtikelPotongs.BacaData("id", kodeAP);
                ArtikelPotongs artikel = new ArtikelPotongs(listAp[0].IdArtikelPotongs, listAp[0].Brand, listAp[0].Kain, listAp[0].Seri,
                    listAp[0].Yard, listAp[0].Size_S, listAp[0].Size_M, listAp[0].Size_L, listAp[0].Size_XL);

                Bagians b = new Bagians(int.Parse(hasil.GetValue(3).ToString()),artikel, hasil.GetValue(5).ToString(), int.Parse(hasil.GetValue(6).ToString()), int.Parse(hasil.GetValue(7).ToString()));
                //Terambils t = new Terambils(g, b, int.Parse(hasil.GetValue(3).ToString()));

                Terambils t = new Terambils(artikel.IdArtikelPotongs,artikel.Seri,b.Bagian, int.Parse(hasil.GetValue(2).ToString()),b.Biaya_Satuan);

                listTerambils.Add(t);
            }
            return listTerambils;
        }
        public static int HitungGaji(int biayasatuan, int kasbon, int potongankasbon, int diambil, Bagians b)
        {

            int Subtotal = b.Biaya_Satuan * diambil;
            int gaji = Subtotal - potongankasbon + kasbon;


            return gaji;
        }
        #endregion
    }
}