using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        #endregion
    }
}