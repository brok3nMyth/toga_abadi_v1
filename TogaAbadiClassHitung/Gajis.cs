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
        public Gajis(int idGaji, int diambil, int subtotal, int sisaKasbon, int kasbon, int totalKasbon, int potonganKasbon, int totalGaji, Pekerjas pekerjas, Bagians bagians)
        {
            IdGaji = idGaji;
            Diambil = diambil;
            Subtotal = subtotal;
            SisaKasbon = sisaKasbon;
            Kasbon = kasbon;
            TotalKasbon = totalKasbon;
            PotonganKasbon = potonganKasbon;
            TotalGaji = totalGaji;
            Pekerjas = pekerjas;
            Bagians = bagians;
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
        public static void TambahData(Gajis parGajis)
        {
            string sql = "INSERT INTO Gajis(pekerjas_id,models_id,diambil,subtotal,sisaKasbon,kasbon,totalKasbon,potonganKasbon,totalGaji) values ('" 
                + parGajis.Pekerjas.IdPekerjas + "', '" + parGajis.Bagians.IdBagians + "', '" + parGajis.Diambil + "', '" +parGajis.Subtotal + "', '" +parGajis.SisaKasbon+ "', '" +
                parGajis.Kasbon+ "', '" +parGajis.TotalKasbon + "', '" +parGajis.PotonganKasbon+ "', '" +parGajis.TotalGaji+ "')";

            Koneksi.JalankanPerintahDML(sql);
        }
        //ubah data
        public static void HapusData(Gajis parGajis)
        {
            string sql = "DELETE FROM Gajis WHERE id='" + parGajis.IdGaji + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        //lihat data 

        public static List<Gajis> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                //sql = "select B.idBagians, B.id_artikel, B.bagian, B.tersedia, B.biaya_satuan from Bagians B ";
                sql = "SELECT * FROM gajis g" +
                    "LEFT JOIN bagians b on g.models_id = b.id " +
                    "LEFT JOIN pekerjas p on g.pekerjas_id = p.id";
                    //"SELECT * FROM gajis g " +"LEFT JOIN bagians b on g.models_id = b.id" +"LEFT JOIN artikelpotongs ap on ap.id = b.id_artikel";
            }
            else
            {
                sql = "SELECT * FROM gajis g" +
                    "LEFT JOIN bagians b on g.models_id = b.id " +
                    "LEFT JOIN pekerjas p on g.pekerjas_id = p.id WHERE" + kriteria + " LIKE '%" +
                    nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Gajis> listGajis = new List<Gajis>();
            while (hasil.Read() == true)
            {
                Bagians b = new Bagians(int.Parse(hasil.GetValue(11).ToString()), hasil.GetValue(13).ToString(), int.Parse(hasil.GetValue(14).ToString()), int.Parse(hasil.GetValue(15).ToString()));
                
                Pekerjas p = new Pekerjas(int.Parse(hasil.GetValue(16).ToString()), hasil.GetValue(17).ToString());

                Gajis g = new Gajis(int.Parse(hasil.GetValue(0).ToString()), int.Parse(hasil.GetValue(3).ToString()), int.Parse(hasil.GetValue(4).ToString()),
                    int.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()), int.Parse(hasil.GetValue(7).ToString()),
                    int.Parse(hasil.GetValue(8).ToString()), int.Parse(hasil.GetValue(9).ToString()), p, b);

                listGajis.Add(g);
            }
            return listGajis;
        }
        public static int HitungGaji(Gajis g)
        {
            int Subtotal = g.Subtotal;
            int SisaKasbon = g.SisaKasbon;
            int Kasbon = g.Kasbon;
            int TotalKasbon = g.TotalKasbon;
            int PotonganKasbon = g.PotonganKasbon;
            int gaji = Subtotal - ((SisaKasbon + Kasbon)-PotonganKasbon);//perlu di improve


            return gaji;
        }
        #endregion
    }
}