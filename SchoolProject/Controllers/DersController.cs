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
    public class DersController : Controller
    {
        DersManager dm = new DersManager(new EfDersDal());
       
        public ActionResult GetDers()
        {
            var dersvalues = dm.GetList();
            return View(dersvalues);
        }
        [HttpGet]
        public ActionResult AddDers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDers(tDers p)
        {

            dm.DersAdd(p);
            return RedirectToAction("GetDers");

            return View();
        }

        public ActionResult DeleteDers(int id)
        {
            var dersvalues = dm.GetByID(id);
            dm.DersDelete(dersvalues);
            return RedirectToAction("GetDers");
        }
        [HttpGet]
        public ActionResult EditDers(int id)
        {
            var dersvalues = dm.GetByID(id);
            return View(dersvalues);
        }

        [HttpPost]
        public ActionResult EditDers(tDers p)
        {
            dm.DersUpdate(p);
            return RedirectToAction("GetDers");
        }
    }
}