using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoC.Controllers.TeacherController
{
    public class CourseController : Controller
    {
        // GET: Course

        //Edit CourseName
        public ActionResult EditCourse()
        {
            return View();
        }

        public ActionResult DeleteCourse()
        {
            return View();
        }

    }
}