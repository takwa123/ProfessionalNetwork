using ProfessionalNetwork.Models;
using ProfessionalNetwork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfessionalNetwork.Controllers
{
    public class ApplicationController : Controller
    {

        public ApplicationService _IApplicationService { get; set; }

        public ApplicationController()
        {
            _IApplicationService = new ApplicationService();
        }
        // GET: Application
        public ActionResult Index()
        {
            var l = _IApplicationService.GetAll();
            List<ApplicationVM> lo = new List<ApplicationVM>();
            foreach (var item in l)
            {
                lo.Add(
                    new ApplicationVM
                    {
                        Job_OfferFK = item.Job_OfferFK,
                        Job_SeekerFK = item.Job_SeekerFK,
                        Date_Application = item.Date_Application,
                        State = item.State,
                    }
                 );
            }
            return View(lo);
        }

        // GET: Application/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Application/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Application/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Application/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Application/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Application/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Application/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
