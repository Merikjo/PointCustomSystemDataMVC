﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PointCustomSystemDataMVC.Models;
using PointCustomSystemDataMVC.ViewModels;
using System.Security.Claims;

namespace PointCustomSystemDataMVC.Controllers
{
    [Authorize(Roles = "Personnel User")]
    public class TreatmentPlacesController : Controller
    {   
        private JohaMeriSQL1Entities db = new JohaMeriSQL1Entities();

        // GET: TreatmentPlaces
        public ActionResult Index()
        {
            string username = User.Identity.Name;
            string userid = ((ClaimsPrincipal)User).Claims?.Where(c => c.Type == ClaimTypes.GroupSid).FirstOrDefault()?.Value ?? "";

            List<TreatmentPlaceViewModel> model = new List<TreatmentPlaceViewModel>();

            JohaMeriSQL1Entities entities = new JohaMeriSQL1Entities();
            try
            {
                List<TreatmentPlace> treatplaces = entities.TreatmentPlace.ToList();
                // muodostetaan näkymämalli tietokannan rivien pohjalta
                foreach (TreatmentPlace treatplace in treatplaces)
                {
                    TreatmentPlaceViewModel view = new TreatmentPlaceViewModel();
                    view.TreatmentPlace_id = treatplace.TreatmentPlace_id;
                    view.TreatmentPlaceName = treatplace.TreatmentPlaceName;
                    view.TreatmentPlaceNumber = treatplace.TreatmentPlaceNumber;

                    model.Add(view);
                }
            }
            finally
            {
                entities.Dispose();
            }

                return View(model);
        }//Index

      
        // GET: TreatmentPlaces/Details/5
        //public ActionResult Details(int? id)
        //{
        //    TreatmentPlaceViewModel model = new TreatmentPlaceViewModel();

        //    JohaMeriSQL1Entities entities = new JohaMeriSQL1Entities();
        //    try
        //    {
        //        if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    TreatmentPlace treatmentPlace = db.TreatmentPlace.Find(id);
        //    if (treatmentPlace == null)
        //    {
        //        return HttpNotFound();
        //    }

        //        // muodostetaan näkymämalli tietokannan rivien pohjalta  
        //        TreatmentPlaceViewModel view = new TreatmentPlaceViewModel();
        //        view.TreatmentPlace_id = treatmentPlace.TreatmentPlace_id;
        //        view.TreatmentPlaceName = treatmentPlace.TreatmentPlaceName;
        //        view.TreatmentPlaceNumber = treatmentPlace.TreatmentPlaceNumber;

        //        model = view;
        //    }
        //    finally
        //    {
        //        entities.Dispose();
        //    }

        //    return View(model);
        //}//details


        // GET: TreatmentPlaces/Create
        public ActionResult Create()
        {
            string username = User.Identity.Name;
            string userid = ((ClaimsPrincipal)User).Claims?.Where(c => c.Type == ClaimTypes.GroupSid).FirstOrDefault()?.Value ?? "";

            JohaMeriSQL1Entities db = new JohaMeriSQL1Entities();

            TreatmentPlaceViewModel model = new TreatmentPlaceViewModel();

            return View(model);

        }//create

        // POST: TreatmentPlaces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TreatmentPlaceViewModel model)
        {
            string username = User.Identity.Name;
            string userid = ((ClaimsPrincipal)User).Claims?.Where(c => c.Type == ClaimTypes.GroupSid).FirstOrDefault()?.Value ?? "";

            JohaMeriSQL1Entities db = new JohaMeriSQL1Entities();

            TreatmentPlace trp = new TreatmentPlace();
            trp.TreatmentPlaceName = model.TreatmentPlaceName;
            trp.TreatmentPlaceNumber = model.TreatmentPlaceNumber;

            db.TreatmentPlace.Add(trp);

            try
            {
                db.SaveChanges();
            }

            catch (Exception ex)
            {
            }
    
            return RedirectToAction("Index");
        }
    

        // GET: TreatmentPlaces/Edit/5
        public ActionResult Edit(int? id)
        {
            string username = User.Identity.Name;
            string userid = ((ClaimsPrincipal)User).Claims?.Where(c => c.Type == ClaimTypes.GroupSid).FirstOrDefault()?.Value ?? "";

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TreatmentPlace treatmentPlace = db.TreatmentPlace.Find(id);
            if (treatmentPlace == null)
            {
                return HttpNotFound();
            }

            TreatmentPlaceViewModel treatplace = new TreatmentPlaceViewModel();
            treatplace.TreatmentPlace_id = treatmentPlace.TreatmentPlace_id;
            treatplace.TreatmentPlaceName = treatmentPlace.TreatmentPlaceName;
            treatplace.TreatmentPlaceNumber = treatmentPlace.TreatmentPlaceNumber;
     
            return View(treatplace);
        }

        // POST: TreatmentPlaces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TreatmentPlaceViewModel model)
        {
            string username = User.Identity.Name;
            string userid = ((ClaimsPrincipal)User).Claims?.Where(c => c.Type == ClaimTypes.GroupSid).FirstOrDefault()?.Value ?? "";

            TreatmentPlace treatplace = db.TreatmentPlace.Find(model.TreatmentPlace_id);

            treatplace.TreatmentPlaceName = model.TreatmentPlaceName;
            treatplace.TreatmentPlaceNumber = model.TreatmentPlaceNumber;

            db.SaveChanges();

            return RedirectToAction("Index");

        }//edit

        // GET: TreatmentPlaces/Delete/5
        public ActionResult Delete(int? id)
        {
            string username = User.Identity.Name;
            string userid = ((ClaimsPrincipal)User).Claims?.Where(c => c.Type == ClaimTypes.GroupSid).FirstOrDefault()?.Value ?? "";

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TreatmentPlace treatmentPlace = db.TreatmentPlace.Find(id);
            if (treatmentPlace == null)
            {
                return HttpNotFound();
            }

            TreatmentPlaceViewModel view = new TreatmentPlaceViewModel();
            view.TreatmentPlace_id = treatmentPlace.TreatmentPlace_id;
            view.TreatmentPlaceName = treatmentPlace.TreatmentPlaceName;
            view.TreatmentPlaceNumber = treatmentPlace.TreatmentPlaceNumber;

            return View(view);
        }//Delete


        // POST: TreatmentPlaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string username = User.Identity.Name;
            string userid = ((ClaimsPrincipal)User).Claims?.Where(c => c.Type == ClaimTypes.GroupSid).FirstOrDefault()?.Value ?? "";

            TreatmentPlace treatmentPlace = db.TreatmentPlace.Find(id);
            db.TreatmentPlace.Remove(treatmentPlace);
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
        } //Delete
    }
}
