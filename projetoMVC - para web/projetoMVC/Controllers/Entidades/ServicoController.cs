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
    public class ServicoController : Controller
    {
        private BDContext db = new BDContext();

        //
        // GET: /Servico/

        public ActionResult Index()
        {
            var servicos = db.Servicos.Include(s => s.Pessoa);
            return View(servicos.ToList());
        }

        //
        // GET: /Servico/Details/5

        public ActionResult Details(int id = 0)
        {
            Servico servico = db.Servicos.Find(id);
            if (servico == null)
            {
                return HttpNotFound();
            }
            return View(servico);
        }

        //
        // GET: /Servico/Create

        public ActionResult Create()
        {
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome");
            return View();
        }

        //
        // POST: /Servico/Create

        [HttpPost]
        public ActionResult Create(Servico servico)
        {
            if (ModelState.IsValid)
            {
                db.Servicos.Add(servico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", servico.sCpf);
            return View(servico);
        }

        //
        // GET: /Servico/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Servico servico = db.Servicos.Find(id);
            if (servico == null)
            {
                return HttpNotFound();
            }
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", servico.sCpf);
            return View(servico);
        }

        //
        // POST: /Servico/Edit/5

        [HttpPost]
        public ActionResult Edit(Servico servico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", servico.sCpf);
            return View(servico);
        }

        //
        // GET: /Servico/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Servico servico = db.Servicos.Find(id);
            if (servico == null)
            {
                return HttpNotFound();
            }
            return View(servico);
        }

        //
        // POST: /Servico/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Servico servico = db.Servicos.Find(id);
            db.Servicos.Remove(servico);
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