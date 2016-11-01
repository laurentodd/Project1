using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Degrees()
        {
             ViewBag.Message = "Learn about the degrees offered in Information Systems";
            return View();
        }
        
        
        public ActionResult SelectedDegree(string degree)
        {
            if (degree == "BSIS")
            {
                ViewBag.Title = "Bachelor of Science Information Systems";
                ViewBag.DegreeName = "Bachelor's of Science Information Systems";
                ViewBag.Coordinator = "Dr. Conan Albrecht";
                ViewBag.ProfTitle = "Professor of Information Systems";
                ViewBag.Address = "780 TNRB";
                ViewBag.PhD = "Doctor of Philosophy, Management, Management Information Systems Department, University of Arizona, 2000";
                ViewBag.Masters = "Masters of Accountancy, School of Accountancy and Information Systems, Brigham Young University, 1997";
                ViewBag.Bachelors = "Bachelors of Science, School of Accountancy and Information Systems, Brigham Young University, 1997";
                ViewBag.Picture = Url.Content("http://www.devincollier.com/wp-content/uploads/albrecht.jpg");
            }

            else if (degree == "MISM") {
                ViewBag.Title = "Masters of Information Systems Management";
                ViewBag.DegreeName = "Masters of Information Systems Management";
                ViewBag.Coordinator = "Dr. Bonnie Anderson";
                ViewBag.ProfTitle = "Associate Professor of Information Systems";
                ViewBag.Address = "776 TNRB";
                ViewBag.PhD = "Doctor of Philosophy, Information Systems, Carnegie Mellon University, 2001";
                ViewBag.Masters = "Masters of Philosophy, Piblic Policy,  Carnegie Mellon University, 2000";
                ViewBag.Masters = "Masters of Accounting, Information Systems, Brigham Young University, 1995";
                ViewBag.Bachelors = "Bachelors of Science, School of Accountancy, Brigham Young University, 1995";
                ViewBag.Picture = Url.Content("http://neurosecurity.byu.edu/wp-content/uploads/2015/01/bonnie_brinton_anderson.jpg");

            }
            return View();
        }
    }
}