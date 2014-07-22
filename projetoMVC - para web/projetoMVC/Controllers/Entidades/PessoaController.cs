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
    public class PessoaController : Controller
    {
        private BDContext db = new BDContext();

        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            return View(db.Pessoas.ToList());
        }

        //
        // GET: /Pessoa/Details/5

        public ActionResult Details(string id = null)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        //
        // GET: /Pessoa/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pessoa/Create

        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        //
        // GET: /Pessoa/Edit/5

        public ActionResult Edit(string id = null)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        //
        // POST: /Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        //
        // GET: /Pessoa/Delete/5

        public ActionResult Delete(string id = null)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        //
        // POST: /Pessoa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            db.Pessoas.Remove(pessoa);
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