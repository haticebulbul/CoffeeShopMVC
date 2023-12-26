using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Entity;

namespace CoffeeShop.Controllers
{
    [Authorize(Roles = "admin")]
    public class AksesuarUrunsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: AksesuarUruns
        public ActionResult Index()
        {
            return View(db.AksesuarUrunler.ToList());
        }

        // GET: AksesuarUruns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AksesuarUrun aksesuarUrun = db.AksesuarUrunler.Find(id);
            if (aksesuarUrun == null)
            {
                return HttpNotFound();
            }
            return View(aksesuarUrun);
        }

        // GET: AksesuarUruns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AksesuarUruns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "urunId,UrunName,urunType,urunAciklama,urunFiyat,urunStok,Resim,AksesuarKategoriId")] AksesuarUrun aksesuarUrun)
        {
            if (ModelState.IsValid)
            {
                db.AksesuarUrunler.Add(aksesuarUrun);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aksesuarUrun);
        }

        // GET: AksesuarUruns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AksesuarUrun aksesuarUrun = db.AksesuarUrunler.Find(id);
            if (aksesuarUrun == null)
            {
                return HttpNotFound();
            }
            return View(aksesuarUrun);
        }

        // POST: AksesuarUruns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "urunId,UrunName,urunType,urunAciklama,urunFiyat,urunStok,Resim,AksesuarKategoriId")] AksesuarUrun aksesuarUrun)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aksesuarUrun).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aksesuarUrun);
        }

        // GET: AksesuarUruns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AksesuarUrun aksesuarUrun = db.AksesuarUrunler.Find(id);
            if (aksesuarUrun == null)
            {
                return HttpNotFound();
            }
            return View(aksesuarUrun);
        }

        // POST: AksesuarUruns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AksesuarUrun aksesuarUrun = db.AksesuarUrunler.Find(id);
            db.AksesuarUrunler.Remove(aksesuarUrun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
