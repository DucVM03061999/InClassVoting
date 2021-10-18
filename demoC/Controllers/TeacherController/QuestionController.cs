using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoC.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question

        //Get question list by chapter (Question Bank)
        public ActionResult ViewQuestionByChapter()
        {
            return View();
        }

        public ActionResult MultipleChoice()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}