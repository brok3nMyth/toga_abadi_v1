﻿using System;
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
        private int subtotal;
        private int kasbon;
        private int totalGaji;
        private string tempat;
        private string tanggal;
        private string bulan;
        private string tahun;
        private string nama;
        public Pekerjas pekerjas;

        #endregion

        #region constructor
        public Gajis(int idGaji, string tempat,  int subtotal, int kasbon, int totalGaji,  string tanggal,string bulan, string tahun,Pekerjas pekerjas)
        {
            IdGaji = idGaji;
            Tempat = tempat;
            Subtotal = subtotal;
            Kasbon = kasbon;
            TotalGaji = totalGaji;
            Pekerjas = pekerjas;
            Tanggal = tanggal;
            Bulan = bulan;
            Tahun = tahun;
            //Bagians = bagians;
        }
        public Gajis(int idGaji, string tempat, int subtotal, int kasbon, int totalGaji, string tanggal, string bulan, string tahun, string nama)
        {
            IdGaji = idGaji;
            Tempat = tempat;
            Subtotal = subtotal;
            Kasbon = kasbon;
            TotalGaji = totalGaji;
            Tanggal = tanggal;
            Bulan = bulan;
            Tahun = tahun;
            Nama = nama;
        }
        public Gajis(string tempat, int subtotal, int kasbon, int totalGaji, string tanggal, string bulan, string tahun, Pekerjas pekerjas)
        { 
            Tempat = tempat;
            Subtotal = subtotal;
            Kasbon = kasbon;
            TotalGaji = totalGaji;
            Pekerjas = pekerjas;
            Tanggal = tanggal;
            Bulan = bulan;
            Tahun = tahun;
        }

        public Gajis(string tempat, int subtotal, int kasbon, int totalGaji)
        {
            Tempat = tempat;
            Subtotal = subtotal;
            Kasbon = kasbon;
            TotalGaji = totalGaji;
            
        }

        public Pekerjas Pekerjas
        {
            get => default(Pekerjas);
            set
            {
            }
        }


        #endregion

        #region properties
        public int IdGaji { get => idGaji; set => idGaji = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }
        public int Kasbon { get => kasbon; set => kasbon = value; }
        public int TotalGaji { get => totalGaji; set => totalGaji = value; }
        public string Tempat { get => tempat; set => tempat = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Bulan { get => bulan; set => bulan = value; }
        public string Tahun { get => tahun; set => tahun = value; }
        #endregion

        #region method
        public static void TambahData(Gajis parGajis, Pekerjas parPekerjas,DateTime tanggal)
        { 
            string date = tanggal.Day.ToString();
            string month = tanggal.Month.ToString();
            string year = tanggal.Year.ToString();
            //consider : buat db menjadi tanggal, bulan, tahun. sehingga data terpisah, tersimpan sebagai string.
            string sql = "INSERT INTO Gajis(pekerjas_id, tempat, subtotal,kasbon,totalGaji,tanggal,bulan,tahun) values ('"
                + parPekerjas.IdPekerjas + "', '" + parGajis.Tempat + "' , '" + parGajis.Subtotal + "', '" +
                parGajis.Kasbon + "', '" + parGajis.TotalGaji +"', '"+date+ "', '" + month + "', '" + year + "')";

            //string sql = "INSERT INTO Gajis(pekerjas_id,models_id,diambil,subtotal,kasbon,totalGaji) values ('" 
            //+parGajis.Pekerjas.IdPekerjas + "', '" + parGajis.Bagians.IdBagians + "', '" + parGajis.Diambil + "', '" + parGajis.Subtotal + "', '" +
            //parGajis.Kasbon + "', '" + parGajis.TotalGaji + "')";

            Koneksi.JalankanPerintahDML(sql);
/*
            //string sql2 = "select SCOPE_IDENTITY()";
            string sql2 = "SELECT id FROM `gajis` ORDER BY id DESC LIMIT 1";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql2);
            hasil.Read();
            int id = int.Parse(hasil.GetValue(0).ToString());
            return id;*/
        }
        //ubah data
        public static void UbahData(Gajis parGajis)
        {
            string sql2 = "SELECT id FROM `gajis` ORDER BY id DESC LIMIT 1";
            MySqlDataReader hasil2 = Koneksi.JalankanPerintahQuery(sql2);
            hasil2.Read();
            int idGajis = int.Parse(hasil2.GetValue(0).ToString());

            string sql = "Update Gajis set subtotal='" + parGajis.Subtotal +"' ,kasbon='"+parGajis.Kasbon+"' ,totalGaji='"+parGajis.TotalGaji+
                "' where id ='" + idGajis + "'";


            Koneksi.JalankanPerintahDML(sql);
        }
        public static void HapusData(Terambils parTerambils)
        {
            string sql = "DELETE FROM Terambils where gajis_id ='" + parTerambils.Gajis.IdGaji +
                "' AND bagians_id = '" + parTerambils.Bagians.IdBagians + "'";

            Koneksi.JalankanPerintahDML(sql);
        }

        //lihat data 

        public static List<Gajis> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                //sql = "select B.idBagians, B.id_artikel, B.bagian, B.tersedia, B.biaya_satuan from Bagians B ";
                sql = "SELECT * FROM gajis g " +
                        "LEFT JOIN terambils t on g.id = t.gajis_id " +
                        "LEFT JOIN bagians b on t.bagians_id = b.id " +
                        "LEFT JOIN pekerjas p on g.pekerjas_id = p.id ";
                    //"SELECT * FROM gajis g " +"LEFT JOIN bagians b on g.models_id = b.id" +"LEFT JOIN artikelpotongs ap on ap.id = b.id_artikel";
            }
            else
            {
                sql = "SELECT * FROM gajis g " +
                        "LEFT JOIN terambils t on g.id = t.gajis_id " +
                        "LEFT JOIN bagians b on t.bagians_id = b.id " +
                        "LEFT JOIN pekerjas p on g.pekerjas_id = p.id WHERE g." 
                        + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Gajis> listGajis = new List<Gajis>();
            while (hasil.Read() == true)
            {
                List<ArtikelPotongs> listap = ArtikelPotongs.BacaData("id", hasil.GetValue(14).ToString());
                //ArtikelPotongs ap = new ArtikelPotongs(listap[0].IdArtikelPotongs, listap[0].Brand, listap[0].Kain,
                //    listap[0].Seri, listap[0].Yard, listap[0].Size_S, listap[0].Size_M, listap[0].Size_L, listap[0].Size_XL);

                //Bagians b = new Bagians(int.Parse(hasil.GetValue(7).ToString()),ap, hasil.GetValue(9).ToString(), int.Parse(hasil.GetValue(10).ToString()), int.Parse(hasil.GetValue(11).ToString()));
                
                Pekerjas p = new Pekerjas(int.Parse(hasil.GetValue(17).ToString()), hasil.GetValue(18).ToString(), hasil.GetValue(19).ToString(), hasil.GetValue(20).ToString());
                //DateTime tanggal = DateTime.Parse(hasil.GetValue(3).ToString());
                Gajis g = new Gajis(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(2).ToString(), int.Parse(hasil.GetValue(4).ToString()),
                    int.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()), 
                    hasil.GetValue(7).ToString(), hasil.GetValue(8).ToString(), hasil.GetValue(9).ToString(), p.Nama);

                listGajis.Add(g);
            }
            return listGajis;
        }
        public static List<Gajis> BacaData2(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                //sql = "select B.idBagians, B.id_artikel, B.bagian, B.tersedia, B.biaya_satuan from Bagians B ";
                sql = "SELECT * FROM gajis g " +
                        "LEFT JOIN pekerjas p on g.pekerjas_id = p.id ";
                //"SELECT * FROM gajis g " +"LEFT JOIN bagians b on g.models_id = b.id" +"LEFT JOIN artikelpotongs ap on ap.id = b.id_artikel";
            }
            else
            {
                sql = "SELECT * FROM gajis g " +
                        "LEFT JOIN pekerjas p on g.pekerjas_id = p.id WHERE g."
                        + kriteria + " LIKE '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Gajis> listGajis = new List<Gajis>();
            while (hasil.Read() == true)
            {
                //List<ArtikelPotongs> listap = ArtikelPotongs.BacaData("id", hasil.GetValue(14).ToString());
                //ArtikelPotongs ap = new ArtikelPotongs(listap[0].IdArtikelPotongs, listap[0].Brand, listap[0].Kain,
                //    listap[0].Seri, listap[0].Yard, listap[0].Size_S, listap[0].Size_M, listap[0].Size_L, listap[0].Size_XL);

                //Bagians b = new Bagians(int.Parse(hasil.GetValue(7).ToString()),ap, hasil.GetValue(9).ToString(), int.Parse(hasil.GetValue(10).ToString()), int.Parse(hasil.GetValue(11).ToString()));

                Pekerjas p = new Pekerjas(int.Parse(hasil.GetValue(9).ToString()), hasil.GetValue(10).ToString(), hasil.GetValue(11).ToString(), hasil.GetValue(12).ToString());
                //DateTime tanggal = DateTime.Parse(hasil.GetValue(3).ToString());
                Gajis g = new Gajis(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(2).ToString(), int.Parse(hasil.GetValue(3).ToString()), int.Parse(hasil.GetValue(4).ToString()),
                    int.Parse(hasil.GetValue(5).ToString()), hasil.GetValue(6).ToString(),
                    hasil.GetValue(7).ToString(), hasil.GetValue(8).ToString(), p.Nama);

                listGajis.Add(g);
            }
            return listGajis;
        }
        public static int checkKasbon(string nama)
        {
            string sql = "";
                sql = "SELECT g.kasbon FROM gajis g " +
                        "LEFT JOIN pekerjas p on g.pekerjas_id = p.id WHERE p.nama"
                        + " LIKE '%" + nama + "%' ORDER BY g.id DESC LIMIT 1";
            
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            int kasbonlama = 0;
            while (hasil.Read() == true)
            {

                kasbonlama = int.Parse(hasil.GetValue(0).ToString());

            }
            
            return kasbonlama;
        }
        public static int HitungGaji(int biayasatuan,int kasbon, int potongankasbon,int diambil, Bagians b)
        {
            
            int Subtotal = b.Biaya_Satuan * diambil;
            int gaji = Subtotal - potongankasbon + kasbon;


            return gaji;
        }
        #endregion
    }
}