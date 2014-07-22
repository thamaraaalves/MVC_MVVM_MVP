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
    public class EnderecoController : Controller
    {
        private BDContext db = new BDContext();

        //
        // GET: /Endereco/

        public ActionResult Index()
        {
            var enderecos = db.Enderecos.Include(e => e.Pessoa);
            return View(enderecos.ToList());
        }

        //
        // GET: /Endereco/Details/5

        public ActionResult Details(int id = 0)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            return View(endereco);
        }

        //
        // GET: /Endereco/Create

        public ActionResult Create()
        {
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome");
            return View();
        }

        //
        // POST: /Endereco/Create

        [HttpPost]
        public ActionResult Create(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                db.Enderecos.Add(endereco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", endereco.sCpf);
            return View(endereco);
        }

        //
        // GET: /Endereco/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", endereco.sCpf);
            return View(endereco);
        }

        //
        // POST: /Endereco/Edit/5

        [HttpPost]
        public ActionResult Edit(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(endereco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", endereco.sCpf);
            return View(endereco);
        }

        //
        // GET: /Endereco/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return HttpNotFound();
            }
            return View(endereco);
        }

        //
        // POST: /Endereco/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            db.Enderecos.Remove(endereco);
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