using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirst_ExistingDB;
using System.Data.SqlClient;

namespace CodeFirst_ExistingDB.Controllers
{
    public class ProfesorController : Controller
    {
        private ProfesorDBContext db = new ProfesorDBContext();

        // GET: Profesor
        public ActionResult Index()
        {
            /*
             * Code Firts
             */
            //return View(db.Profesor.ToList());

            /*
             * Code Firts con SP
             */
            var getAll = db.Database.SqlQuery<TBL_Profesor>("sp_GetAllProfesor");
            return View(getAll.ToList());
        }

        // GET: Profesor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Profesor tBL_Profesor = db.Profesor.Find(id);
            if (tBL_Profesor == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Profesor);
        }

        // GET: Profesor/Create
        public ActionResult Create()
        {
            //ViewBag.Days = TBL_Profesor.DaySelectList.Select(d => new SelectListItem { Text = d.ToString() });
            //ViewBag.Months = TBL_Profesor.MonthSelectList.Select((m, i) => new SelectListItem
            //{
            //    Value = (i + 1).ToString(),
            //    Text = m
            //});
            //ViewBag.Years = TBL_Profesor.YearSelectList.Select(y => new SelectListItem { Text = y.ToString() });

            return View();
        }

        // POST: Profesor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdProfesor,Nombre,ApellidoPaterno,ApellidoMaterno,DiaNacimiento,MesNacimiento,AnoNacimiento,LugardeNacimiento,Domicilio,CorreoElectronico,Telefono")] TBL_Profesor tBL_Profesor)
        {
            /*
            * Code Firts
            */
            //if (ModelState.IsValid)
            //{
            //    db.Profesor.Add(tBL_Profesor);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(tBL_Profesor);

            /*
             * Code Firts con SP
             */
            if (ModelState.IsValid)
            {
                db.Profesor.Add(tBL_Profesor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tBL_Profesor);
        }

        // GET: Profesor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Profesor tBL_Profesor = db.Profesor.Find(id);
            if (tBL_Profesor == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Profesor);
        }

        // POST: Profesor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdProfesor,Nombre,ApellidoPaterno,ApellidoMaterno,DiaNacimiento,MesNacimiento,AnoNacimiento,LugardeNacimiento,Domicilio,CorreoElectronico,Telefono")] TBL_Profesor tBL_Profesor)
        {
            /*
            * Code Firts
            */
            //if (ModelState.IsValid)
            //{
            //    db.Entry(tBL_Profesor).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(tBL_Profesor);

            /*
             * Code Firts con SP
             */
            if (ModelState.IsValid)
            {
                db.Entry(tBL_Profesor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tBL_Profesor);
        }

        // GET: Profesor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_Profesor tBL_Profesor = db.Profesor.Find(id);
            if (tBL_Profesor == null)
            {
                return HttpNotFound();
            }
            return View(tBL_Profesor);
        }

        // POST: Profesor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            /*
             * Code Firts
             */
            //TBL_Profesor tBL_Profesor = db.Profesor.Find(id);
            //db.Profesor.Remove(tBL_Profesor);
            //db.SaveChanges();
            //return RedirectToAction("Index");

            /*
             * Code Firts con SP
             */
            TBL_Profesor tBL_Profesor = db.Profesor.Find(id);
            db.Profesor.Remove(tBL_Profesor);
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
