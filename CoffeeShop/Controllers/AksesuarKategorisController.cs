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
    [Authorize(Roles ="admin")]
    public class AksesuarKategorisController : Controller
    {
        private DataContext db = new DataContext();

        // GET: AksesuarKategoris
        public ActionResult Index()
        {
            return View(db.aksesuarKategoriler.ToList());
        }

        // GET: AksesuarKategoris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AksesuarKategori aksesuarKategori = db.aksesuarKategoriler.Find(id);
            if (aksesuarKategori == null)
            {
                return HttpNotFound();
            }
            return View(aksesuarKategori);
        }

        // GET: AksesuarKategoris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AksesuarKategoris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AksesuarKategorId,kategoriName,Aciklama")] AksesuarKategori aksesuarKategori)
        {
            if (ModelState.IsValid)
            {
                db.aksesuarKategoriler.Add(aksesuarKategori);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aksesuarKategori);
        }

        // GET: AksesuarKategoris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AksesuarKategori aksesuarKategori = db.aksesuarKategoriler.Find(id);
            if (aksesuarKategori == null)
            {
                return HttpNotFound();
            }
            return View(aksesuarKategori);
        }

        // POST: AksesuarKategoris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AksesuarKategorId,kategoriName,Aciklama")] AksesuarKategori aksesuarKategori)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aksesuarKategori).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aksesuarKategori);
        }

        // GET: AksesuarKategoris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AksesuarKategori aksesuarKategori = db.aksesuarKategoriler.Find(id);
            if (aksesuarKategori == null)
            {
                return HttpNotFound();
            }
            return View(aksesuarKategori);
        }

        // POST: AksesuarKategoris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AksesuarKategori aksesuarKategori = db.aksesuarKategoriler.Find(id);
            db.aksesuarKategoriler.Remove(aksesuarKategori);
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
