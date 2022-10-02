using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apsis_190421.Models;
using System.Data.SqlClient;
using System.Data;

namespace Apsis_190421.Models
{
    public class VeriModel 
    {
        private SqlConnection baglanti;

        private void baglan()
        {
            //bağlantı cümlesini program.cs'den getir.
            baglanti = new SqlConnection(Program.cumle);
            baglanti.Open();
        }
        public bool veriEkle(tablo tabloL)
        {
            baglan();
            string sql = "Insert into UyeDurumTablosu (Kisi_ad,Kisi_soyad,Kisi_daire,Kisi_aidat,Kisi_aylik_durum,Kisi_yillik_durum) Values (@Kisi_ad,@Kisi_soyad,@Kisi_daire,@Kisi_aidat,@Kisi_aylik_durum,@Kisi_yillik_durum)";
            SqlCommand kom = new SqlCommand(sql, baglanti);
            kom.Parameters.AddWithValue("@Kisi_ad", tabloL.Kisi_ad);
            kom.Parameters.AddWithValue("@Kisi_soyad", tabloL.Kisi_soyad);
            kom.Parameters.AddWithValue("@Kisi_daire", tabloL.Kisi_daire);
            kom.Parameters.AddWithValue("@Kisi_aidat", tabloL.Kisi_aidat);
            kom.Parameters.AddWithValue("@Kisi_aylik_durum", tabloL.Kisi_aylik_durum);
            kom.Parameters.AddWithValue("@Kisi_yillik_durum", tabloL.Kisi_yillik_durum);
            int etkilenen = 0;
            etkilenen = kom.ExecuteNonQuery();
            baglanti.Close();
            if (etkilenen >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<tablo> veriGoster()
        {
            baglan();
            List<tablo> tabloL = new List<tablo>();
            string sql = "Select * from UyeDurumTablosu Order By Id";
            SqlCommand kom = new SqlCommand(sql, baglanti);
            SqlDataAdapter adap = new SqlDataAdapter(kom);
            DataTable gosterTablo = new DataTable();
            adap.Fill(gosterTablo);
            baglanti.Close();
            foreach (DataRow veri in gosterTablo.Rows)
            {
                tabloL.Add(new tablo
                {
                    Id = Convert.ToInt32(veri["Id"]),
                    Kisi_ad = Convert.ToString(veri["Kisi_ad"]),
                    Kisi_soyad = Convert.ToString(veri["Kisi_soyad"]),
                    Kisi_daire = Convert.ToString(veri["Kisi_daire"]),
                    Kisi_aidat = Convert.ToString(veri["Kisi_aidat"]),
                    Kisi_aylik_durum = Convert.ToString(veri["Kisi_aylik_durum"]),
                    Kisi_yillik_durum = Convert.ToString(veri["Kisi_yillik_durum"]),
                });
            }
            return tabloL;
        }

        public bool veriGuncelle(tablo tabloL)
        {
            baglan();
            string sql = "Update UyeDurumTablosu set Kisi_ad=@Kisi_ad,Kisi_soyad=@Kisi_soyad,Kisi_daire=@Kisi_daire,Kisi_aidat=@Kisi_aidat,Kisi_aylik_durum=@Kisi_aylik_durum,Kisi_yillik_durum=@Kisi_yillik_durum Where Id=@Id";
            SqlCommand kom = new SqlCommand(sql, baglanti);
            kom.Parameters.AddWithValue("@Id", tabloL.Id);
            kom.Parameters.AddWithValue("@Kisi_ad", tabloL.Kisi_ad);
            kom.Parameters.AddWithValue("@Kisi_soyad", tabloL.Kisi_soyad);
            kom.Parameters.AddWithValue("@Kisi_daire", tabloL.Kisi_daire);
            kom.Parameters.AddWithValue("@Kisi_aidat", tabloL.Kisi_aidat);
            kom.Parameters.AddWithValue("@Kisi_aylik_durum", tabloL.Kisi_aylik_durum);
            kom.Parameters.AddWithValue("@Kisi_yillik_durum", tabloL.Kisi_yillik_durum);
            int etkilenen = 0;
            etkilenen = kom.ExecuteNonQuery();
            baglanti.Close();
            if (etkilenen >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool veriSil(int Id)
        {
            baglan();
            string sql = "Delete from UyeDurumTablosu where Id=@Id";
            SqlCommand kom = new SqlCommand(sql, baglanti);
            kom.Parameters.AddWithValue("@Id", Id);
            int etkilenen = 0;
            etkilenen = kom.ExecuteNonQuery();
            baglanti.Close();
            if (etkilenen >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
