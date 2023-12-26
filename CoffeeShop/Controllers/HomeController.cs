using CoffeeShop.Entity;
using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        DataContext context=new DataContext();

        public object AksesuarUrun { get; private set; }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Icecek()
        {
            return View();
        }
        public ActionResult Kahve()
        {
            return View();
        }
        public ActionResult Aksesuar()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            var link = context.Hakkimizda.OrderBy(i => i.HakkimizdaId).Select(i=> new Models.Hakkimizda() { HakkimizdaId = i.HakkimizdaId, link = i.link }).AsEnumerable();
            return View(link);
        }

        public ActionResult Listeleme(int? id)
        {
            var urunler = context.Urun.Select(i => new UrunModel()
            {
                urunId = i.urunId,
                urunName = i.urunName,
                urunAciklama = i.urunAciklama.Length > 50 ? i.urunAciklama.Substring(0, 47) + "..." : i.urunAciklama,
                urunType = i.urunType,
                urunFiyat = i.urunFiyat,
                Resim = i.Resim ?? "UrunResmiYok.jpg",
                urunStok = i.urunStok,
                KategoriId = i.KategoriId,

            }).AsQueryable();

            if (id != null)
            {
                urunler=urunler.Where(i=>i.KategoriId == id);
            }



            return View(urunler.ToList());
        }
        public ActionResult Detay(int id)
        {

            return View(context.Urun.Where(i => i.urunId == id).FirstOrDefault());
        }
        public ActionResult UrunListeleme(int? id)
        {
            var aksesuarurunler = context.AksesuarUrunler.Select(i => new AksesuarUrunModel()
            {
                urunId = i.urunId,
                urunName = i.UrunName,
                urunAciklama = i.urunAciklama.Length > 50 ? i.urunAciklama.Substring(0, 47) + "..." : i.urunAciklama,
                urunType = i.urunType,
                urunFiyat = i.urunFiyat,
                Resim = i.Resim ?? "UrunResmiYok.jpg",
                urunStok = i.urunStok,
                AksesuarKategoriId = i.AksesuarKategoriId,

            }).AsQueryable();

            if (id != null)
            {
                aksesuarurunler = aksesuarurunler.Where(i => i.AksesuarKategoriId == id);
            }



            return View(aksesuarurunler.ToList());
        }

        public ActionResult AksesuarDetay(int id)
        {

            return View(context.AksesuarUrunler.Where(i => i.urunId == id).FirstOrDefault());
        }




        public PartialViewResult GetCategories()
        {
            return PartialView(context.Kategoriler.ToList());
        }
        public PartialViewResult GetAksesuarCategories()
        {
            return PartialView(context.aksesuarKategoriler.ToList());
        }

    }

   
}