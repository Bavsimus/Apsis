using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apsis_190421.Models;
using System.Data.SqlClient;
using System.Data;


namespace Apsis_190421.Controllers
{
    public class VeriController : Controller
    {
        private VeriModel veriController = new VeriModel();
        [HttpGet]
        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tablo tabloL) 
        {
            if (ModelState.IsValid)
            {
                if (veriController.veriEkle(tabloL))
                {
                    ViewData["sncmsj"] = "Kayıt başarılı.";
                    ModelState.Clear();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            return View(veriController.veriGoster().Find(verimodeli => verimodeli.Id == Id));
        }
        [HttpPost]
        public ActionResult Edit(int Id,tablo tabloL)
        {
            try
            {
                veriController.veriGuncelle(tabloL);
                return RedirectToAction("yonetici_arayuz" , "Account");
            }
            catch 
            {

                return View();
            }
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            return View(veriController.veriGoster().Find(verimodeli => verimodeli.Id == Id));
        }
        [HttpPost]
        public ActionResult Delete(int Id,tablo tabloL)
        {
            try
            {
                veriController.veriGoster().Find(verimodeli => verimodeli.Id == Id);
                if (veriController.veriSil(Id))
                {
                    ViewData["sncmsj"] = "Kayıt başarıyla silindi.";
                }
                return RedirectToAction("yonetici_arayuz", "Account");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(int Id) 
        {
            return View(veriController.veriGoster().Find(verimodeli => verimodeli.Id == Id));
        }
    }
}
