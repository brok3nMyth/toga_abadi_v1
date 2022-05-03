using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
      
        #endregion
    }
}