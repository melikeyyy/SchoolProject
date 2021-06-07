using SchoolProject.Business;
using SchoolProject.DataAcces.EntityFramework;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProject.Controllers
{
    public class FakulteController : Controller
    {
        // GET: Fakulte
        FakulteManager fm = new FakulteManager(new EfFakulte());
        
        public ActionResult GetFakulte()
        {
            var fakultevalues = fm.GetList();
            return View(fakultevalues);
        }
        [HttpGet]
        public ActionResult AddFakulte()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFakulte(tFakulte p)
        {

            fm.FakulteAdd(p);
            return RedirectToAction("GetFakulte");

            return View();
        }

        public ActionResult DeleteFakulte(int id)
        {
            var fakultevalues = fm.GetByID(id);
            fm.FakulteDelete(fakultevalues);
            return RedirectToAction("GetFakulte");
        }

        [HttpGet]
        public ActionResult EditFakulte(int id)
        {
            var fakultevalues = fm.GetByID(id);
            return View(fakultevalues);
        }

        [HttpPost]
        public ActionResult EditFakulte(tFakulte p)
        {
            fm.FakulteUpdate(p);
            return RedirectToAction("GetFakulte");
        }
    }
}