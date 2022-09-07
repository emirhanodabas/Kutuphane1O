﻿using KutuphaneYonetimi1OEntites.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneYonetimi1O.MVC.Controllers
{
    public class YetkiController : Controller
    {

        KutuphaneContext db = new KutuphaneContext();
        // GET: Yetki
        public ActionResult Index()
        {
            List<Yetki> yetkis = db.Yetki.ToList();
            return View(yetkis);
        }

        [HttpPost]
        public ActionResult Ekle(Yetki pytk)
        {
            pytk.YetkiDurumu = true;
            db.Yetki.Add(pytk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            using (KutuphaneContext db = new KutuphaneContext())
            {
                Yetki yetki = db.Yetki.Find(id);
                yetki.YetkiDurumu = false;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
