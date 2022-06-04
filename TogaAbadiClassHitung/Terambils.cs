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


        #endregion

        #region constructor
        public Terambils(Gajis gajis, Bagians bagians, int diambil)
        {
            Gajis = gajis;
            Bagians = bagians;
            Diambil = diambil;
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
        #endregion

        #region method
        public static void TambahData(Terambils parTerambils)
        {
            string sql = "INSERT INTO Terambils(gajis_id, bagians_id, diambils) values ('"
                + parTerambils.Gajis.IdGaji+ "', '" + parTerambils.Bagians.IdBagians + "', '" + parTerambils.Diambil +"')";

            
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

        public static List<Terambils> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
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
                        "LEFT JOIN gajis g on g.id = t.gajis_id WHERE"
                        + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Terambils> listTerambils = new List<Terambils>();
            while (hasil.Read() == true)
            {
                ArtikelPotongs artikel = new ArtikelPotongs(hasil.GetValue(1).ToString(), hasil.GetValue(5).ToString(), hasil.GetValue(6).ToString(), hasil.GetValue(7).ToString(), int.Parse(hasil.GetValue(8).ToString()), int.Parse(hasil.GetValue(9).ToString()), int.Parse(hasil.GetValue(10).ToString()), int.Parse(hasil.GetValue(11).ToString()), int.Parse(hasil.GetValue(12).ToString()));
                Pekerjas p = new Pekerjas(int.Parse(hasil.GetValue(12).ToString()), hasil.GetValue(13).ToString());

                Gajis g = new Gajis(int.Parse(hasil.GetValue(8).ToString()), hasil.GetValue(10).ToString(), (DateTime)hasil.GetValue(11), int.Parse(hasil.GetValue(12).ToString()), int.Parse(hasil.GetValue(13).ToString()),
                    int.Parse(hasil.GetValue(14).ToString()), p);

                Bagians b = new Bagians(int.Parse(hasil.GetValue(3).ToString()),artikel, hasil.GetValue(5).ToString(), int.Parse(hasil.GetValue(6).ToString()), int.Parse(hasil.GetValue(7).ToString()));
                Terambils t = new Terambils(g, b, int.Parse(hasil.GetValue(3).ToString()));

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