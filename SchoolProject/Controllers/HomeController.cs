using SchoolProject.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           // var context = new Context();
            //context.Database.Create();
            return View();
        }

    }
}