using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using m1g2_2025.Models;

namespace m1g2_2025.Controllers
{
    public class AnnoncesController : Controller
    {
        private m1gl2Context db = new m1gl2Context();

        // GET: Annonces
        public ActionResult Index()
        {
            var annonces = db.annonces.Include(a => a.Bien);
            return View(annonces.ToList());
        }

        // GET: Annonces/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annonce annonce = db.annonces.Find(id);
            if (annonce == null)
            {
                return HttpNotFound();
            }
            return View(annonce);
        }

        // GET: Annonces/Create
        public ActionResult Create()
        {
            ViewBag.Bien_id = new SelectList(db.biens, "IdBien", "LibelleBien");
            return View();
        }

        // POST: Annonces/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAnnonce,DateDebut,DateFin,StatutAnnonce,Bien_id")] Annonce annonce)
        {
            if (ModelState.IsValid)
            {
                db.annonces.Add(annonce);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Bien_id = new SelectList(db.biens, "IdBien", "LibelleBien", annonce.Bien_id);
            return View(annonce);
        }

        // GET: Annonces/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annonce annonce = db.annonces.Find(id);
            if (annonce == null)
            {
                return HttpNotFound();
            }
            ViewBag.Bien_id = new SelectList(db.biens, "IdBien", "LibelleBien", annonce.Bien_id);
            return View(annonce);
        }

        // POST: Annonces/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAnnonce,DateDebut,DateFin,StatutAnnonce,Bien_id")] Annonce annonce)
        {
            if (ModelState.IsValid)
            {
                db.Entry(annonce).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Bien_id = new SelectList(db.biens, "IdBien", "LibelleBien", annonce.Bien_id);
            return View(annonce);
        }

        // GET: Annonces/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annonce annonce = db.annonces.Find(id);
            if (annonce == null)
            {
                return HttpNotFound();
            }
            return View(annonce);
        }

        // POST: Annonces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Annonce annonce = db.annonces.Find(id);
            db.annonces.Remove(annonce);
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
