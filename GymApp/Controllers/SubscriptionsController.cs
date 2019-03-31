using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GymApp.Data;
using GymApp.Models;

namespace GymApp.Controllers
{
    [Authorize]
    public class SubscriptionsController : Controller
    {
        private GymAppDb _db = new GymAppDb();
       
        // GET: Subscriptions
        public ActionResult Index(string searchTerm = null)
        {
            
            var model = _db.Subscriptions.ToList().Where(r => searchTerm == null || r.Name.StartsWith(searchTerm));
            return View(model);
        }
        // GET: Subscriptions/AddASubscription/5
        public ActionResult AddASubscription (int? id, string searchTerm = null)
        {
            var model = _db.Subscriptions.ToList().Where(r => searchTerm == null || r.Name.StartsWith(searchTerm));
            if (id == null)
              {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
              }
    Subscription subscription = _db.Subscriptions.Find(id);
            if (subscription == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
            

       

        // GET: Subscriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscription subscription = _db.Subscriptions.Find(id);
            if (subscription == null)
            {
                return HttpNotFound();
            }
            return View(subscription);
        }

        // GET: Subscriptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subscriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,StartDate,EndDate,CustomerId")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _db.Subscriptions.Add(subscription);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subscription);
        }

        // GET: Subscriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscription subscription = _db.Subscriptions.Find(id);
            if (subscription == null)
            {
                return HttpNotFound();
            }
            return View(subscription);
        }

        // POST: Subscriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,StartDate,EndDate,CustomerId")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(subscription).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subscription);
        }

        // GET: Subscriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscription subscription = _db.Subscriptions.Find(id);
            if (subscription == null)
            {
                return HttpNotFound();
            }
            return View(subscription);
        }

        // POST: Subscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subscription subscription = _db.Subscriptions.Find(id);
            _db.Subscriptions.Remove(subscription);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

       
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
       
    }

}
