//using KutuphaneYonetimi1OEntites.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace KutuphaneYonetimi1O.MVC.Controllers
//{
//    public class KitapOduncVermeController : Controller
//    {
//        // GET: KitapOduncVerme
//        KutuphaneContext db = new KutuphaneContext();
//        public ActionResult Index()
//        {
//            List<KitapHareket> kitaplar = db.KitapHareket.Where(x => x.KitapHareketDurumu == true).ToList();
//            return View(kitaplar.ToList());
            
//        }
//        public ActionResult Sil(int id)
//        {
//            KitapHareket kHareket = db.KitapHareket.Find(id);

//            kHareket.KitapHareketDurumu = false;
//            db.SaveChanges();
//            return RedirectToAction("Index");
//            //db.YayinEvi.Remove(yayinEvi) ;
//        }
//        [HttpGet]
//        public ActionResult KitapOduncVerme()
//        {
//            List<SelectListItem> kitap = db.Kitap.AsNoTracking().Where(k => k.KitapDurumu == true)
//                                       .Select(s => new SelectListItem
//                                       {
//                                           Value = s.KitapId.ToString(),
//                                           Text=s.KitapAdi
//                                       }).ToList();
//            List<SelectListItem> uye = db.Uye.AsNoTracking().Where(k => k.UyeDurumu == true)
//                                       .Select(s => new SelectListItem
//                                       {
//                                           Value = s.UyeId.ToString(),
//                                           Text = s.UyeAdi +" "+s.UyeSoyadi
//                                       }).ToList();
//            List<SelectListItem> personel = db.Personel.AsNoTracking().Where(k => k.PersonelDurumu == true)
//                                       .Select(s => new SelectListItem
//                                       {
//                                           Value = s.PersonelId.ToString(),
//                                           Text = s.PersonelAdi + " " + s.PersonelSoyadi
//                                       }).ToList();
         
//            ViewBag.Kitap = kitap;
//            ViewBag.Uye = uye;
//            ViewBag.Personel = personel;
//            return View();

//        }
        
//        [HttpPost]
//        public ActionResult KitapOduncVerme(KitapHareket pHareket)
//        {
//            pHareket.Kitap = db.Kitap.Find(pHareket.KitapId);
//            pHareket.Uye = db.Uye.Find(pHareket.UyeId);
//            pHareket.Personel = db.Personel.Find(pHareket.PersonelId);
//            pHareket.KitapHareketDurumu = true;
//            db.KitapHareket.Add(pHareket);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }
//    }
//}
