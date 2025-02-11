using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using m1g2_2025.Models;
using PagedList;

namespace m1g2_2025.Controllers
{
    public class BiensController : Controller
    {
        private m1gl2Context db = new m1gl2Context();
        const int pageSize = 2;
        // GET: Biens
        public ActionResult Index(string libelle, string region, int? page)
        {
            ViewBag.libelle = libelle != null ? libelle: string.Empty;
            ViewBag.region = region != null ? region : string.Empty;
            page = page ?? 1;
            int pageNumber = (int)page;

            var liste = db.biens.ToList();

            if (!string.IsNullOrEmpty(libelle))
            {
                liste = liste.Where(a=>a.LibelleBien.ToLower().Contains(libelle.ToLower())).ToList();    
            }
            if (!string.IsNullOrEmpty(region))
            {
                liste = liste.Where(a => a.Region.ToLower().Contains(region.ToLower())).ToList();
            }


            return View(liste.ToPagedList(pageNumber,pageSize));
        }

        // GET: Biens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bien bien = db.biens.Find(id);
            if (bien == null)
            {
                return HttpNotFound();
            }
            return View(bien);
        }

        // GET: Biens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Biens/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdBien,LibelleBien,DescriptionBien,PrixJournalier,Region,Pays,Latitude,Longitude,NbreChambre,NbreLit,TypeBien")] Bien bien)
        {
            if (ModelState.IsValid)
            {
                db.biens.Add(bien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bien);
        }

        // GET: Biens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bien bien = db.biens.Find(id);
            if (bien == null)
            {
                return HttpNotFound();
            }
            return View(bien);
        }

        // POST: Biens/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdBien,LibelleBien,DescriptionBien,PrixJournalier,Region,Pays,Latitude,Longitude,NbreChambre,NbreLit,TypeBien")] Bien bien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bien);
        }

        // GET: Biens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bien bien = db.biens.Find(id);
            if (bien == null)
            {
                return HttpNotFound();
            }
            return View(bien);
        }

        // POST: Biens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bien bien = db.biens.Find(id);
            db.biens.Remove(bien);
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
