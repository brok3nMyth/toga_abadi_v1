using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Transactions;
using System.Drawing.Printing;

namespace classProject
{
    public class NotaBeli
    {
        #region Field
        private string noNotaBeli;
        private DateTime tanggal;
        private Supplier supplier;
        private List<NotaBeliDetil> listNotaBeliDetil;
        #endregion

        #region Contructor
        public NotaBeli(Supplier supplier, string noNotaBeli, DateTime tanggal)
        {
            Supplier = supplier;
            NoNotaBeli = noNotaBeli;
            Tanggal = tanggal;
            ListNotaBeliDetil = new List<NotaBeliDetil>();
        }
        #endregion

        #region Properties
        public string NoNotaBeli { get => noNotaBeli; set => noNotaBeli = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public List<NotaBeliDetil> ListNotaBeliDetil { get => listNotaBeliDetil; private set => listNotaBeliDetil = value; }
        #endregion

        #region Method
        public static void TambahData(NotaBeli nota)
        {
            using (TransactionScope transcope = new TransactionScope())
            {
                try
                {
                    string sql1 = "INSERT into NotaBeli(NoNotaBeli, Tanggal, KodeSupplier) values('" +
                         nota.NoNotaBeli + "','" + nota.Tanggal.ToString("yyy-MM-dd hh:mm:ss") + "','" +
                         nota.Supplier.KodeSupplier + "')";
                    Koneksi.JalankanPerintahDML(sql1);
                    foreach (NotaBeliDetil detilNota in nota.ListNotaBeliDetil)
                    {
                        string sql2 = "INSERT into NotaBeliDetil(NoNotaBeli, KodeBarang, Harga, Jumlah) values ('" +
                                      nota.NoNotaBeli + "','" + detilNota.Barang.KodeBarang + "','" +
                                      detilNota.Harga + "','" + detilNota.Jumlah + "')";
                        Koneksi.JalankanPerintahDML(sql2);



                        Barang.UpdateStok("Pembelian", detilNota.Barang.KodeBarang, detilNota.Jumlah);
                    }
                    transcope.Complete();
                }
                catch (Exception)
                {
                    transcope.Dispose();
                    throw (new Exception("Penyimpanan Nota Beli gagal."));
                }
            }
        }

        public void TambahNotaBeliDetil(Barang barang, int harga, int jumlah)
        {
            NotaBeliDetil detilNota = new NotaBeliDetil(harga, jumlah, barang);
            this.ListNotaBeliDetil.Add(detilNota);
        }

        public static string GenerateNoNota()
        {
            string sql = "select RIGHT(NoNotaBeli,3) as NoUrutTransaksi" + " from notabeli " +
                "where Date(Tanggal) = Date(Current_date)" + "order by Tanggal DESC limit 1";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            string hasilNoNota = "";
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int noUrutTrans = int.Parse(hasil.GetValue(0).ToString()) + 1;
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

        public static List<NotaBeli> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql1 = "";
            if (kriteria == "")
            {
                sql1 = "SELECT N.NoNotaBeli, N.Tanggal, N.KodeSupplier, S.Nama as NamaSupplier, S.Telepon as TeleponSupplier " +
                        "FROM NotaBeli N INNER JOIN Supplier as S ON N.KodeSupplier = S.KodeSupplier " +
                        "ORDER BY N.NoNotaBeli DESC ";
            }
            else
            {
                sql1 = "SELECT N.NoNotaBeli, N.Tanggal, N.KodeSupplier, S.Nama as NamaSupplier, S.Telepon as TeleponSupplier " +
                       "FROM NotaBeli N INNER JOIN Supplier as S ON N.KodeSupplier = S.KodeSupplier " +
                       "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%' " +
                       "ORDER BY N.NoNotaBeli DESC ";
            }
            MySqlDataReader hasilData1 = Koneksi.JalankanPerintahQuery(sql1);
            List<NotaBeli> listHasilData = new List<NotaBeli>();

            while (hasilData1.Read() == true)
            {
                string nomorNota = hasilData1.GetValue(0).ToString();
                DateTime tglNota = DateTime.Parse(hasilData1.GetValue(1).ToString());
                List<Supplier> listSupplier = Supplier.BacaData("KodeSupplier", hasilData1.GetValue(2).ToString());
                NotaBeli nota = new NotaBeli(listSupplier[0], nomorNota, tglNota);
                string sql2 = "SELECT NBD.KodeBarang, B.Nama, NBD.Harga, NBD.Jumlah " +
                              "FROM NotaBeli N INNER JOIN NotaBeliDetil NBD ON N.NoNotaBeli = NBD.NoNotaBeli " +
                              "INNER JOIN Barang B ON NBD.KodeBarang = B.KodeBarang " +
                              "WHERE N.NoNotaBeli = '" + nomorNota + "'";
                MySqlDataReader hasilData2 = Koneksi.JalankanPerintahQuery(sql2);

                while (hasilData2.Read() == true)
                {
                    List<Barang> listBarang = Barang.BacaData("B.KodeBarang", hasilData2.GetValue(0).ToString());
                    int hargaBeli = int.Parse(hasilData2.GetValue(2).ToString());
                    int jumlahBeli = int.Parse(hasilData2.GetValue(3).ToString());
                    NotaBeliDetil detilNota = new NotaBeliDetil(jumlahBeli, hargaBeli, listBarang[0]);
                    nota.TambahNotaBeliDetil(listBarang[0], hargaBeli, jumlahBeli);
                }
                listHasilData.Add(nota);
            }
            return listHasilData;

        }

        public static void CetakNota(string pKriteria, string pNilaiKriteria, string pNamaFile, Font pFont)
        {
            List<NotaBeli> listNotaBeli = new List<NotaBeli>();
            listNotaBeli = NotaBeli.BacaData(pKriteria, pNilaiKriteria);

            StreamWriter file = new StreamWriter(pNamaFile);

            foreach (NotaBeli nota in listNotaBeli)
            {
                file.WriteLine("");
                file.WriteLine("TOKO 3 PERMATA");
                file.WriteLine("Jl. Raya , Surabaya");
                file.WriteLine("Telp. (031) - (isi)");
                file.WriteLine("=".PadRight(50, '='));


                file.WriteLine("No.Nota : " + nota.NoNotaBeli);
                file.WriteLine("Tanggal : " + nota.Tanggal);
                file.WriteLine("");
                file.WriteLine("");
                file.WriteLine("=".PadRight(10, '='));

                int grandTotal = 0;
                foreach (NotaBeliDetil nbd in nota.ListNotaBeliDetil)
                {
                    string nama = nbd.Barang.Nama;
                    if (nama.Length > 30)
                    {
                        nama = nama.Substring(0, 30);

                    }
                    int jumlah = nbd.Jumlah;
                    int harga = nbd.Harga;
                    int subtotal = jumlah * harga;

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