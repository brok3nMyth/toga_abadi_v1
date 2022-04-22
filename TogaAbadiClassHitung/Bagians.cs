using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TogaAbadiClassHitung
{
    public class Bagians
    {
        private int idBagians;
        private string bagian;
        private int tersedia;
        private int biaya_Satuan;

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

        public int IdBagians { get => idBagians; set => idBagians = value; }
        public string Bagian { get => bagian; set => bagian = value; }
        public int Tersedia { get => tersedia; set => tersedia = value; }
        public int Biaya_Satuan { get => biaya_Satuan; set => biaya_Satuan = value; }
    }
}