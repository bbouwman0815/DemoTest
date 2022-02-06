using SharedLibraryDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CapstoneWebsiteDemo.Controllers
{
    public class HomeController : Controller
    {
        private CapstoneDemoDatabaseEntities db = new CapstoneDemoDatabaseEntities();

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

        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "StudentID,LastName,FirstName,EnrollmentDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.StudentID == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Student student2 = db.Students.Where(s => s.LastName == student.LastName).Where(s => s.FirstName == student.FirstName).FirstOrDefault<Student>();
                if (student2 == null)
                {
                    return HttpNotFound();
                }
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}