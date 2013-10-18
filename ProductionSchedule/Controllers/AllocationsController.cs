using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductionSchedule.Models;

namespace ProductionSchedule.Controllers
{   
    public class AllocationsController : Controller
    {
        private ProductionScheduleContext context = new ProductionScheduleContext();

        //
        // GET: /Allocations/

        public ViewResult Index()
        {
            return View(context.Allocations.ToList());
        }

        //
        // GET: /Allocations/Details/5

        public ViewResult Details(int id)
        {
            Allocation allocation = context.Allocations.Single(x => x.AllocationId == id);
            return View(allocation);
        }

        //
        // GET: /Allocations/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Allocations/Create

        [HttpPost]
        public ActionResult Create(Allocation allocation)
        {
            if (ModelState.IsValid)
            {
                context.Allocations.Add(allocation);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(allocation);
        }
        
        //
        // GET: /Allocations/Edit/5
 
        public ActionResult Edit(int id)
        {
            Allocation allocation = context.Allocations.Single(x => x.AllocationId == id);
            return View(allocation);
        }

        //
        // POST: /Allocations/Edit/5

        [HttpPost]
        public ActionResult Edit(Allocation allocation)
        {
            if (ModelState.IsValid)
            {
                context.Entry(allocation).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(allocation);
        }

        //
        // GET: /Allocations/Delete/5
 
        public ActionResult Delete(int id)
        {
            Allocation allocation = context.Allocations.Single(x => x.AllocationId == id);
            return View(allocation);
        }

        //
        // POST: /Allocations/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Allocation allocation = context.Allocations.Single(x => x.AllocationId == id);
            context.Allocations.Remove(allocation);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}