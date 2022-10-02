using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apsis_190421.Models;
using System.Data.SqlClient;

namespace Apsis_190421.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection bag = new SqlConnection();
        SqlCommand kom = new SqlCommand();
        SqlDataReader dr;
        private VeriModel veriController = new VeriModel();

        void sqlBaglan()
        {
            bag.ConnectionString = @"data source=176.53.65.202\MSSQLSERVER2019; database=apsissit_DB; integrated security=False; User ID=apsissit_talib; Password=Sqse71^5;";
            bag.Open();
            kom.Connection = bag;
        }

        [HttpGet]
        public ActionResult yonetici_arayuz()
        {
            ModelState.Clear();
            return View(veriController.veriGoster());
        }

        [HttpGet]
        public ActionResult uye_giris()
        {
            return View();
        }

        [HttpGet]
        public ActionResult yonetici_giris()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Kontrol(Account acc) 
        {

            sqlBaglan();
            kom.CommandText = "Select * from UyeHesapTablosu where HesapID='"+acc.HesapID+"' and HesapPW='"+acc.HesapPW+"'";
            dr = kom.ExecuteReader();
             
            if (dr.Read())
            {
                bag.Close();
                doldur_arayuz();
                return View("uye_arayuz");
            }
            else
            {
                bag.Close();
                return View("giris_hata");
            }

        }
        
        [HttpPost]
        public ActionResult Kontrol2(Account acc)
        {

            sqlBaglan();
            kom.CommandText = "Select * from YoneticiHesapTablosu where HesapID='" + acc.HesapID + "' and HesapPW='" + acc.HesapPW + "'";
            dr = kom.ExecuteReader();

            if (dr.Read())
            {
                bag.Close();
                doldur_arayuz();
                return View("yonetici_arayuz");
            }
            else
            {
                bag.Close();
                return View("giris_hata");
            }

        }

        [HttpPost]
        public ActionResult doldur_arayuz() 
        {
            ModelState.Clear();
            return View(veriController.veriGoster());
        }      
    }
}
