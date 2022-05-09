using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TogaAbadiClassHitung
{
    public class Bagians
    {
        #region fields 
        private int idBagians;
        private string bagian;
        private int tersedia;
        private int biaya_Satuan;
        #endregion

        #region constructor
        public Bagians(int idBagians, string bagian, int tersedia, int biaya_Satuan)
        {
            IdBagians = idBagians;
            Bagian = bagian;
            Tersedia = tersedia;
            Biaya_Satuan = biaya_Satuan;
        }
        public ArtikelPotongs ArtikelPotongs
        {
            get => default(ArtikelPotongs);
            set
            {
            }
        }
        #endregion

        #region properties
        public int IdBagians { get => idBagians; set => idBagians = value; }
        public string Bagian { get => bagian; set => bagian = value; }
        public int Tersedia { get => tersedia; set => tersedia = value; }
        public int Biaya_Satuan { get => biaya_Satuan; set => biaya_Satuan = value; }

        #endregion
        #region method
        public static void TambahData(Bagians parBagians)
        {
            string sql = "INSERT INTO Bagians(Bagians, Tersedia, biaya_Satuan) values ('" + parBagians.Bagian+ "', '" + parBagians.Tersedia+ "', '" + parBagians.Biaya_Satuan+ "')";

            Koneksi.JalankanPerintahDML(sql);
        }
        //ubah data
        public static void HapusData(Bagians parBagians)
        {
            string sql = "DELETE FROM Bagians WHERE Username='" + parBagians.IdBagians + "'";

            Koneksi.JalankanPerintahDML(sql);
        }
        #endregion
    }
}
