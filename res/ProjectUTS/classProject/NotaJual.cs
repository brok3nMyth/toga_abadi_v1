using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Transactions;
using System.Drawing;
using System.IO;
using System.Drawing.Printing;

namespace classProject
{
    public class NotaJual
    {
        #region Field
        private string kodeNotaJual;
        private DateTime tanggal;
        private Pelanggan pelanggan;
        private List<NotaJualDetil> listNotaJualDetil;
        #endregion

        #region Contructor
        public NotaJual(string kodeNotaJual, DateTime tanggal, Pelanggan pelanggan)
        {
            KodeNotaJual = kodeNotaJual;
            Tanggal = tanggal;
            Pelanggan = pelanggan;
            ListNotaJualDetil = new List<NotaJualDetil>();
        }
        #endregion

        #region Properties
        public string KodeNotaJual { get => kodeNotaJual; set => kodeNotaJual = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }

        public List<NotaJualDetil> ListNotaJualDetil { get => listNotaJualDetil; private set => listNotaJualDetil = value; }
        #endregion

        #region Method

        

        public static void TambahData(NotaJual nota)
        {
            using (TransactionScope transcope = new TransactionScope())
            {
                try
                {
                    string sql1 = "INSERT into NotaJual(NoNotaJual, Tanggal, KodePelanggan) values('" +
                         nota.KodeNotaJual + "','" + nota.Tanggal.ToString("yyy-MM-dd hh:mm:ss") + "','" + nota.Pelanggan.KodePelanggan + "')";
                    Koneksi.JalankanPerintahDML(sql1);
                    foreach (NotaJualDetil detilNota in nota.ListNotaJualDetil)
                    {
                        string sql2 = "INSERT into NotaJualDetil(NoNotaJual, KodeBarang, Harga, Jumlah) values ('" +
                                      nota.KodeNotaJual + "','" + detilNota.Barang.KodeBarang + "','" +
                                      detilNota.Harga + "','" + detilNota.Jumlah + "')";
                        Koneksi.JalankanPerintahDML(sql2);



                        Barang.UpdateStok("penjualan", detilNota.Barang.KodeBarang, detilNota.Jumlah);
                    }
                    transcope.Complete();
                }
                catch (Exception)
                {
                    transcope.Dispose();
                    throw (new Exception("Penyimpanan Nota Jual gagal."));

                }
            }
        }

        public void TambahNotaJualDetil(Barang barang, int harga, int jumlah, double diskon)
        {
            NotaJualDetil detilNota = new NotaJualDetil(barang, harga, jumlah, diskon);
            this.ListNotaJualDetil.Add(detilNota);
        }

        public static string GenerateNoNota()
        {
            string sql = "select RIGHT(NoNotaJual,3) as NoUrutTransaksi" + " from notajual " +
                "where Date(Tanggal) = Date(Current_date)" + "order by Tanggal DESC limit 1";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            string hasilNoNota = "";
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int noUrutTrans = int.Parse(hasil.GetValue(0).ToString()) +1;
                    //gunakan padLeft
                    hasilNoNota = DateTime.Now.Year +
                                  DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                  DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                  noUrutTrans.ToString().PadLeft(3, '0');
                }
            }
            else
            {
                hasilNoNota = DateTime.Now.Year +
                                  DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                  DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                 "001";
            }
            return hasilNoNota;

        }

        public static List<NotaJual> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql1 = "";
            if (kriteria == "")
            {
                sql1 = "SELECT N.NoNotaJual, N.Tanggal, N.KodePelanggan, Pelanggan.Nama AS NamaPelanggan," +
                    " Pelanggan.Telepon AS TeleponPelanggan " + 
                    "FROM notajual N INNER JOIN Pelanggan ON N.KodePelanggan = Pelanggan.KodePelanggan " + 
                    "ORDER BY N.NoNotaJual DESC";
            }
            else
            {
                sql1 = "SELECT N.NoNotaJual, N.Tanggal, N.KodePelanggan, Pelanggan.Nama AS NamaPelanggan," +
                    " Pelanggan.Telepon AS TeleponPelanggan " +
                       "FROM notajual N INNER JOIN Pelanggan ON N.KodePelanggan = Pelanggan.KodePelanggan " +
                       "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'" + 
                       "ORDER BY N.NoNotaJual DESC";
            }

            //Data Reader 1: Memeperoleh semua data dari NotaJual
            MySqlDataReader hasilData1 = Koneksi.JalankanPerintahQuery(sql1);
            List<NotaJual> listHasilData = new List<NotaJual>();

            while (hasilData1.Read() == true)
            {
                string nomorNota = hasilData1.GetValue(0).ToString();

                DateTime tanggalNota = DateTime.Parse(hasilData1.GetValue(1).ToString());

                List<Pelanggan> listOfPelanggan = Pelanggan.BacaData("KodePelanggan", hasilData1.GetValue(2).ToString());
                

                NotaJual nota = new NotaJual(nomorNota, tanggalNota, listOfPelanggan[0]);

                string sql2 = "SELECT NotaJualDetil.KodeBarang, Barang.Nama, NotaJualDetil.Harga, NotaJualDetil.Jumlah, NotaJualDetil.Diskon " +
                              "FROM NotaJual INNER JOIN NotaJualDetil ON NotaJual.NoNotaJual = NotaJualDetil.NoNotaJual " +
                              "INNER JOIN Barang ON NotaJualDetil.KodeBarang = Barang.KodeBarang " +
                              "WHERE NotaJual.NoNotaJual = '" + nomorNota + "'";

                //Data Reader 2: Memperoleh semua data barang dari NotaJualDetil
                MySqlDataReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);

                while (hasilData2.Read() == true)
                {
                    //Barang terjual
                    List<Barang> listBarang = Barang.BacaData("B.KodeBarang", hasilData2.GetValue(0).ToString());

                    int hargaJual = int.Parse(hasilData2.GetValue(2).ToString());
                    int jumlahJual = int.Parse(hasilData2.GetValue(3).ToString());
                    double diskonjual = double.Parse(hasilData2.GetValue(4).ToString());

                    NotaJualDetil detilNota = new NotaJualDetil(listBarang[0], hargaJual, jumlahJual,diskonjual);

                    nota.TambahNotaJualDetil(listBarang[0], hargaJual, jumlahJual, diskonjual);
                }

                listHasilData.Add(nota);
            }
            return listHasilData;
        }

        public static void CetakNota(string pKriteria, string pNilaiKriteria, string pNamaFile, Font pFont)
        {
            List<NotaJual> listNotaJual = new List<NotaJual>();
            listNotaJual = NotaJual.BacaData(pKriteria, pNilaiKriteria);

            StreamWriter file = new StreamWriter(pNamaFile);

            foreach (NotaJual nota in listNotaJual)
            {
                file.WriteLine("");
                file.WriteLine("TOKO 3 PERMATA");
                file.WriteLine("Jl. Raya , Surabaya");
                file.WriteLine("Telp. (031) - (isi)");
                file.WriteLine("=".PadRight(50, '='));


                file.WriteLine("No.Nota : " + nota.KodeNotaJual);
                file.WriteLine("Tanggal : " + nota.Tanggal);
                file.WriteLine("");
                file.WriteLine("Pelanggan : " + nota.Pelanggan.Nama);
                file.WriteLine("");
                file.WriteLine("=".PadRight(10, '='));

                double grandTotal = 0;
                foreach (NotaJualDetil njd in nota.ListNotaJualDetil)
                {
                    string nama = njd.Barang.Nama;
                    if (nama.Length > 30)
                    {
                        nama = nama.Substring(0, 30);

                    }
                    int jumlah = njd.Jumlah;
                    int harga = njd.Harga;
                    double diskon = (njd.Diskon/100);
                    double subtotal = (jumlah * harga)-(diskon*(jumlah * harga));

                    file.Write(nama.PadRight(30, ' '));
                    file.Write(jumlah.ToString().PadRight(3, ' '));
                    file.Write(harga.ToString("#,###").PadRight(7, ' '));
                    file.Write(subtotal.ToString("#,###").PadRight(10, ' '));
                    file.WriteLine("");
                    grandTotal = grandTotal + subtotal;
                }

                file.WriteLine("=".PadRight(50, '='));
                file.WriteLine("TOTAL : " + grandTotal.ToString("#,###"));
                file.WriteLine("=".PadRight(50, '='));
                file.WriteLine("Terima Kasih \n Telah berbelanja di toko kami");
                file.WriteLine("");
            }
            file.Close();

            Cetak c = new Cetak(pNamaFile, pFont, 20, 10, 10, 10);
            c.CetakKePrinter("text");
        }

        #endregion
    }
}