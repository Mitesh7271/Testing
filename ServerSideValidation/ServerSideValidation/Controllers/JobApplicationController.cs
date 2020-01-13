using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo.MVC.Models;

namespace demo.MVC.Controllers
{
    public class JobApplicationController : Controller
    {
        // GET: JobApplication
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(JobApplication jobApplication)
        {
            if (ModelState.IsValid)
                ViewBag.Result = "Form Submitted Successfully";
            else
                ViewBag.Result = "Invalid Entries, Kindly Recheck.";
            return View();
        }

        [HttpPost]
        public ActionResult Reset()
        {
            return RedirectToAction("Index");
        }
    }
}