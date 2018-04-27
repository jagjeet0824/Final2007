using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using comp2007w2018finalB.Models;

namespace comp2007w2018finalB.Controllers
{
    [Authorize]
    public class BreweriesController : Controller
    {
        private IMockBreweryRepository db;

        // default constructor for web app using db
        public BreweriesController()
        {
            this.db = new EFBreweryRepository();
        }

        public BreweriesController(IMockBreweryRepository mock)
        {
            this.db = mock;
        }

        // GET: Breweries
        public ActionResult Index()
        {
            return View(db.Breweries.ToList());
        }

        // GET: Breweries/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Breweries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BreweryId,Name,City,Url,Logo")] Brewery brewery)
        {
            if (ModelState.IsValid)
            {
                //db.Breweries.Add(brewery);
                db.Save(brewery);
                return RedirectToAction("Index");
            }

            return View("Create",brewery);
        }
    }
}
