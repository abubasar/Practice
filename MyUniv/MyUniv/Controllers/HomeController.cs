using MyUniv.Models;
using MyUniv.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyUniv.Controllers
{
    
    public class HomeController : Controller
    {
        private SchoolDbEntities db = new SchoolDbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<EnrollmentDetails> data = from student in db.Student
                                                 group student by student.EnrollmentDate into dateGroup
                                                 select new EnrollmentDetails
                                                 {
                                                     EnrollmentDate = dateGroup.Key,
                                                     StudentCount=dateGroup.Count()

                                                 };

            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}