﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ArtGallery.Data.DAL;

namespace ArtGallery.Controllers
{
    [Authorize]
    public class ConfigurationsController : Controller
    {
        private ArtBrowserDBContext db = new ArtBrowserDBContext();

        // GET: Configurations
        public ActionResult Index()
        {
            return View(db.Configurations.ToList());
        }

        // GET: Configurations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Configuration configuration = db.Configurations.Find(id);
            if (configuration == null)
            {
                return HttpNotFound();
            }
            return View(configuration);
        }

        // GET: Configurations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Configurations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Key,Value")] Configuration configuration)
        {
            if (ModelState.IsValid)
            {
                db.Configurations.Add(configuration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(configuration);
        }

        // GET: Configurations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Configuration configuration = db.Configurations.Find(id);
            if (configuration == null)
            {
                return HttpNotFound();
            }
            return View(configuration);
        }

        // POST: Configurations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConfigurationId,Key,Value")] Configuration configuration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(configuration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(configuration);
        }

        // GET: Configurations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Configuration configuration = db.Configurations.Find(id);
            if (configuration == null)
            {
                return HttpNotFound();
            }

            db.Configurations.Remove(configuration);
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
