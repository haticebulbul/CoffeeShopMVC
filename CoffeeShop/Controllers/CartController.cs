using CoffeeShop.Entity;
using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class CartController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }
        public ActionResult AddToCart(int urunId, int? kategoriId, int? aksesuarKategoriId)
        {
            var urun = db.Urun.FirstOrDefault(i => i.urunId == urunId);
            var aksesuarurun = db.AksesuarUrunler.FirstOrDefault(i => i.urunId == urunId);
            if (urun != null )
            {
                if(kategoriId.HasValue)
                GetCart().AddUrun(urun,  1);

                if (aksesuarKategoriId.HasValue)
                    GetCart().AddAksesuarUrun(aksesuarurun, 1);
            }


            return RedirectToAction("Index");
        }
        public ActionResult RemoveFromCart(int urunId)
        {
            var urun = db.Urun.FirstOrDefault(i => i.urunId == urunId);
            var aksesuarurun = db.AksesuarUrunler.FirstOrDefault(i => i.urunId == urunId);
            if (urun != null)
            {
                GetCart().DeleteUrun(urun);
                GetCart().DeleteAksesuarUrun(aksesuarurun);
            }


            return RedirectToAction("Index");
        }
        public Cart GetCart()
        {

            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;

            }
            return cart;
        }
    }
}
