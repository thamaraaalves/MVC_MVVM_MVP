using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projetoMVC.Models;
using projetoMVC.Models.Entidades;

namespace projetoMVC.Controllers.Entidades
{
    public class EmailController : Controller
    {
        private BDContext db = new BDContext();

        //
        // GET: /Email/

        public ActionResult Index()
        {
            var emails = db.Emails.Include(e => e.Pessoa);
            return View(emails.ToList());
        }

        //
        // GET: /Email/Details/5

        public ActionResult Details(int id = 0)
        {
            Email email = db.Emails.Find(id);
            if (email == null)
            {
                return HttpNotFound();
            }
            return View(email);
        }

        //
        // GET: /Email/Create

        public ActionResult Create()
        {
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome");
            return View();
        }

        //
        // POST: /Email/Create

        [HttpPost]
        public ActionResult Create(Email email)
        {
            if (ModelState.IsValid)
            {
                db.Emails.Add(email);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", email.sCpf);
            return View(email);
        }

        //
        // GET: /Email/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Email email = db.Emails.Find(id);
            if (email == null)
            {
                return HttpNotFound();
            }
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", email.sCpf);
            return View(email);
        }

        //
        // POST: /Email/Edit/5

        [HttpPost]
        public ActionResult Edit(Email email)
        {
            if (ModelState.IsValid)
            {
                db.Entry(email).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", email.sCpf);
            return View(email);
        }

        //
        // GET: /Email/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Email email = db.Emails.Find(id);
            if (email == null)
            {
                return HttpNotFound();
            }
            return View(email);
        }

        //
        // POST: /Email/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Email email = db.Emails.Find(id);
            db.Emails.Remove(email);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}