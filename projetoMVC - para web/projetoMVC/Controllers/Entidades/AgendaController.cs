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
    public class AgendaController : Controller
    {
        private BDContext db = new BDContext();

        //
        // GET: /Agenda/

        public ActionResult Index()
        {
            var agendas = db.Agendas.Include(a => a.Servico);
            return View(agendas.ToList());
        }

        //
        // GET: /Agenda/Details/5

        public ActionResult Details(int id = 0)
        {
            Agenda agenda = db.Agendas.Find(id);
            if (agenda == null)
            {
                return HttpNotFound();
            }
            return View(agenda);
        }

        //
        // GET: /Agenda/Create

        public ActionResult Create()
        {
            ViewBag.nIdServico = new SelectList(db.Servicos, "nIdServico", "sDescricao");
            return View();
        }

        //
        // POST: /Agenda/Create

        [HttpPost]
        public ActionResult Create(Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                db.Agendas.Add(agenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.nIdServico = new SelectList(db.Servicos, "nIdServico", "sDescricao", agenda.nIdServico);
            return View(agenda);
        }

        //
        // GET: /Agenda/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Agenda agenda = db.Agendas.Find(id);
            if (agenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.nIdServico = new SelectList(db.Servicos, "nIdServico", "sDescricao", agenda.nIdServico);
            return View(agenda);
        }

        //
        // POST: /Agenda/Edit/5

        [HttpPost]
        public ActionResult Edit(Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.nIdServico = new SelectList(db.Servicos, "nIdServico", "sDescricao", agenda.nIdServico);
            return View(agenda);
        }

        //
        // GET: /Agenda/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Agenda agenda = db.Agendas.Find(id);
            if (agenda == null)
            {
                return HttpNotFound();
            }
            return View(agenda);
        }

        //
        // POST: /Agenda/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Agenda agenda = db.Agendas.Find(id);
            db.Agendas.Remove(agenda);
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