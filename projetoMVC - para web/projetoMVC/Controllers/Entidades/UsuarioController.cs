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
    public class UsuarioController : Controller
    {
        private BDContext db = new BDContext();

        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            var usuarios = db.Usuarios.Include(u => u.Pessoa);
            return View(usuarios.ToList());
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(string id = null)
        {
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome");
            return View();
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", usuario.sCpf);
            return View(usuario);
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(string id = null)
        {
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", usuario.sCpf);
            return View(usuario);
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.sCpf = new SelectList(db.Pessoas, "sCPF", "sNome", usuario.sCpf);
            return View(usuario);
        }

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(string id = null)
        {
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        //
        // POST: /Usuario/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
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