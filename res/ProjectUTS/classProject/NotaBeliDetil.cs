using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classProject
{
    public class NotaBeliDetil
    {
        #region Field
        private int harga;
        private int jumlah;
        private Barang barang;

        #endregion
        public NotaBeliDetil(int harga, int jumlah, Barang barang)
        {
            Harga = harga;
            Jumlah = jumlah;
            Barang = barang;
        }
        #region CONTRUCTION

        #endregion

        #region PROPERTIES
        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public Barang Barang { get => barang; set => barang = value; }

        #endregion
    }
}