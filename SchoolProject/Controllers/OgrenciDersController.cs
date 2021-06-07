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
    public class OgrenciDersController : Controller
    {
        // GET: OgrenciDers
        public ActionResult Index()
        {
            return View();
        }
        OgrenciDersManager odm = new OgrenciDersManager(new EfOgrenciDersDal());
        
        public ActionResult GetOgrenciDers()
        {
            var ogrencidersvalues = odm.GetList();
            return View(ogrencidersvalues);
        }
       [HttpGet]
        public ActionResult AddOgrenciDers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOgrenciDers(tOgrenciDers p)
        {

            odm.OgrenciDersAdd(p);
            return RedirectToAction("GetOgrenciDers");

            return View();
        }

        public ActionResult DeleteOgrenciDers(int id)
        {
            var ogrencidersvalues = odm.GetByID(id);
            odm.OgrenciDersDelete(ogrencidersvalues);
            return RedirectToAction("GetOgrenciDers");
        }

        [HttpGet]
        public ActionResult EditOgrenciDers(int id)
        {
            var ogrencidersvalues = odm.GetByID(id);
            return View(ogrencidersvalues);
        }

        [HttpPost]
        public ActionResult EditOgrenciDers(tOgrenciDers p)
        {
            odm.OgrenciDersUpdate(p);
            return RedirectToAction("GetOgrenciDers");
        }

        
    }
}
