    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using classProject;
using MySql.Data.MySqlClient;

namespace classProject
{
    public class Barang
    {
        #region Field
        private string barcode;
        private string kodeBarang;
        private string nama;
        private int hargaPerRoll;
        private int hargaPerMeter;
        private int stock;
        private double diameter;
        private Kategori kategori;
        private int jumlah;

        #endregion

        #region Contructor
        public Barang(string kodeBarang, string barcode, string nama, int hargaPerRoll, int hargaPerMeter, int stock, double diameter, Kategori kategori)
        {
            KodeBarang = kodeBarang;
            Nama = nama;
            HargaPerRoll = hargaPerRoll;
            HargaPerMeter = hargaPerMeter;
            Stock = stock;
            Diameter = diameter;
            Kategori = kategori;
            Barcode = barcode;
        }

        public Barang(string kodeBarang, string nama, int jumlah)
        {
            KodeBarang = kodeBarang;
            Nama = nama;
            Jumlah = jumlah;
        }
        #endregion

        #region Properties
        public string Barcode { get => barcode; set => barcode = value; }
        public string KodeBarang { get => kodeBarang; set => kodeBarang = value; }
        public string Nama { get => nama; set => nama = value; }
        public int HargaPerRoll { get => hargaPerRoll; set => hargaPerRoll = value; }
        public int HargaPerMeter { get => hargaPerMeter; set => hargaPerMeter = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Diameter { get => diameter; set => diameter = value; }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        #endregion

        #region Method
        public static List<Barang> PenjualanTerbanyak(string bulan, string tahun)
        {
            string sql = "SELECT distinct barang.kodeBarang,barang.nama, sum( notajualdetil.jumlah )" +
            " FROM notajualdetil inner join barang on barang.kodeBarang = notajualdetil.kodeBarang" +
            " WHERE noNotaJual LIKE '" + tahun + bulan + "%'" +
            " group by kodeBarang order by count(notajualdetil.jumlah ) DESC";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Barang> listBarang = new List<Barang>();
            while (hasil.Read() == true)
            {
                Barang b = new Barang(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(),int.Parse(hasil.GetValue(2).ToString()));

                listBarang.Add(b);
            }
            return listBarang;
        }

        public static void TambahData(Barang b)
        {
            string sql = "Insert into Barang(kodeBarang ,barcode , nama, hargaPerRoll, hargaPerMeter, stock, diameter, KodeKategori) values('"
                + b.KodeBarang + "','" + b.Barcode +
                "','" + b.Nama.Replace("'", "\\'") + "','" + b.HargaPerRoll + "','" + b.HargaPerMeter + "','" + b.Stock + "','" + b.Diameter + "','" + b.Kategori.KodeKategori + "')";

            Koneksi.JalankanPerintahDML(sql);

        }

        public static void UbahData(Barang b)
        {
            string sql = "Update Barang set Nama='" + b.Nama.Replace("'", "\\'") + "',hargaPerRoll = '" + b.HargaPerRoll +
                "', HargaPerMeter='" + b.HargaPerMeter +"',Stock='"+b.Stock+"',Diameter='"+b.Diameter +"',KodeKategori='" + b.Kategori.KodeKategori + "' where KodeBarang='" + b.KodeBarang + "'";
            Koneksi.JalankanPerintahDML(sql);



        }

        public static void HapusData(Barang b)
        {
            string sql = "Delete from Barang where KodeBarang='" + b.KodeBarang + "'";

            Koneksi.JalankanPerintahDML(sql);
        }
        public static void UpdateStok(string jenisTransaksi, string kodebarang, int jumlah)
        {
            string sql = "";
            if (jenisTransaksi == "penjualan")
            {
                sql = "UPDATE barang set stok= stok-" + jumlah + " where kodeBarang='" + kodebarang + "'";
            }
            else if (jenisTransaksi == "pembelian")
            {
                sql = "UPDATE barang set stok= stok+" + jumlah + " where kodeBarang='" + kodebarang + "'";
            }
        }
        public static List<Barang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select  B.KodeBarang, B.Barcode, B.Nama, B.HargaPerRoll, B.HargaPerMeter, B.Stock, B.Diameter, B.KodeKategori, K.Nama AS NamaKategori " +
                    "from Barang B inner join kategori K on B.KodeKategori = K.KodeKategori";
            }
            else
            {
                sql = "select B.KodeBarang, B.Barcode , B.Nama, B.HargaPerRoll, B.HargaPerMeter, B.Stock, B.Diameter, B.KodeKategori, K.Nama AS NamaKategori " +
                    "from Barang B inner join kategori K on B.KodeKategori = K.KodeKategori where " + kriteria + " LIKE '%" +
                    nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Barang> listBarang = new List<Barang>();
            while (hasil.Read() == true)
            {
                Kategori kategori = new Kategori(hasil.GetValue(7).ToString(), hasil.GetValue(7).ToString());
                Barang b = new Barang( hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(),
                    int.Parse(hasil.GetValue(3).ToString()), int.Parse(hasil.GetValue(4).ToString()), int.Parse(hasil.GetValue(5).ToString()), double.Parse(hasil.GetValue(6).ToString()), kategori);

                listBarang.Add(b);
            }
            return listBarang;
        }
        public static string GenerateKode(Kategori k)
        {
            string sql = "select max(right(kodeBarang,3)) from Barang where kodeKategori='" + k.KodeKategori + "' ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilKode = "";

            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")// jika ada barang dengan kategori tsb
                {
                    int kodeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;

                    hasilKode = k.KodeKategori + kodeTerbaru.ToString().PadLeft(3, '0');
                }
                else
                {
                    hasilKode = k.KodeKategori + "001";
                }
            }
            return hasilKode;
        }
        #endregion
    }
}