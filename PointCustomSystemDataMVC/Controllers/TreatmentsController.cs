﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PointCustomSystemDataMVC.Models;

namespace PointCustomSystemDataMVC.Controllers
{
    public class TreatmentsController : Controller
    {
        //[Authorize(Roles = "Personnel User")]
        private JohaMeriSQL1Entities db = new JohaMeriSQL1Entities();

        // GET: Treatments
        public ActionResult Index()
        {
            //string username = User.Identity.Name;
            //string userid = ((ClaimsPrincipal)User).Claims?.Where(c => c.Type == ClaimTypes.GroupSid).FirstOrDefault()?.Value ?? "";

            List<Treatment> model = new List<Treatment>();

            try
            {
                JohaMeriSQL1Entities entities = new JohaMeriSQL1Entities();

                model = entities.Treatment.ToList();
                entities.Dispose();
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.GetType() + ": " + ex.Message;
            }

            //    List<Treatment> treatoffs = entities.Treatment.ToList();

            //    // muodostetaan näkymämalli tietokannan rivien pohjalta

            //    foreach (Treatment treatoff in treatoffs)
            //    {
            //        Treatment view = new Treatment();
            //        view.Treatment_id = treatoff.Treatment_id;
            //        view.TreatmentName = treatoff.TreatmentName;
            //        view.TreatmentTime = treatoff.TreatmentTime;
            //        view.TreatmentPrice = treatoff.TreatmentPrice;

            //        model.Add(view);
            //    }
            //}
            //finally
            //{
            //    entities.Dispose();
            //}

            return View(model);
        }

        // GET: Treatments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatment.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // GET: Treatments/Create
        public ActionResult Create()
        {
            JohaMeriSQL1Entities db = new JohaMeriSQL1Entities();
            //ViewBag.TreatmentPlace_id = new SelectList(db.TreatmentPlace, "Treatmentplace_id", "TreatmentPlaceName");
            List<Treatment> model = new List<Treatment>();
        
            return View(model);
        }

        // POST: Treatments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Treatment model)
        {
            JohaMeriSQL1Entities db = new JohaMeriSQL1Entities();

            Treatment treatment = new Treatment();
            treatment.TreatmentName = model.TreatmentName;
            treatment.TreatmentTime = model.TreatmentTime;
            treatment.TreatmentPrice = model.TreatmentPrice;

            db.Treatment.Add(treatment);
            //if (ModelState.IsValid)
            //{
            try
            {
                db.SaveChanges();
            }

            catch (Exception ex)
            {
            }
                return RedirectToAction("Index");
            }
       

        // GET: Treatments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatment.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
        
            return View(treatment);
        }

        // POST: Treatments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Treatment_id,TreatmentName,TreatmentTime,TreatmentPrice")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treatment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
         
            return View(treatment);
        }

        // GET: Treatments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatment.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // POST: Treatments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Treatment treatment = db.Treatment.Find(id);
            db.Treatment.Remove(treatment);
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
