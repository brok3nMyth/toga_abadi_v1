using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classProject
{
    public class NotaJualDetil
    {
        #region Field
        private int harga;
        private int jumlah;
        private double diskon;
        private Barang barang;
        #endregion

        #region Contructor
        public NotaJualDetil( Barang barang, int harga, int jumlah, double diskon)
        {
            Barang = barang;
            Harga = harga;
            Diskon = diskon;
            Jumlah = jumlah;
        }
        #endregion

        #region Properties
        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public Barang Barang { get => barang; set => barang = value; }
        public double Diskon { get => diskon; set => diskon = value; }
        #endregion

        #region Method

        #endregion
    }
}