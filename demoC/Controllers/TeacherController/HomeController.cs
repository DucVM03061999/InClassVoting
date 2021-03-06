using demoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoC.Controllers
{
    public class HomeController : Controller
    {
        private DBModel db = new DBModel();
        public ActionResult ChapterView()
        {
            return View();
        }
     
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult QuestionBank()
        {
            ViewBag.CourseList = db.Courses.ToList();
            ViewBag.ChapterList = db.Chapters.ToList();
            
            return View();
        }

        
    }
}