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
    public class BolumController : Controller
    {
        BolumManager bm = new BolumManager(new EfBolumDal());
        // GET: Ogrenci
        public ActionResult GetBolum()
        {
            var bolumvalues = bm.GetList();
            return View(bolumvalues);
        }
        [HttpGet]
        public ActionResult AddBolum()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBolum(tBolum p)
        {

            bm.BolumAdd(p);
            return RedirectToAction("GetBolum");

            return View();
        }

        public ActionResult DeleteBolum(int id)
        {
            var bolumvalues = bm.GetByID(id);
            bm.BolumDelete(bolumvalues);
            return RedirectToAction("GetBolum");
        }

        [HttpGet]
        public ActionResult EditBolum(int id)
        {
            var bolumvalues = bm.GetByID(id);
            return View(bolumvalues);
        }

        [HttpPost]
        public ActionResult EditBolum(tBolum p)
        {
            bm.BolumUpdate(p);
            return RedirectToAction("GetBolum");
        }
    }
}