using SchoolProject.Entities;
using SchoolProject.Business;
using SchoolProject.DataAcces.Abstract;
using SchoolProject.DataAcces.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolProject.Controllers
{
    public class OgrenciController : Controller
    {
        OgrenciManager om = new OgrenciManager(new EfOgrenciDal());
        // GET: Ogrenci
        public ActionResult GetOgrenci()
        {
            var ogrencivalues = om.GetList();
            return View(ogrencivalues);
        }
        [HttpGet]
        public ActionResult AddOgrenci()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOgrenci(tOgrenci p)
        {
           
                om.OgrenciAdd(p);
                return RedirectToAction("GetOgrenci");
           
            return View();
        }

        public ActionResult DeleteOgrenci(int id)
        {
            var ogrencivalues = om.GetByID(id);
            om.OgrenciDelete(ogrencivalues);
            return RedirectToAction("GetOgrenci");
        }

        [HttpGet]
        public ActionResult EditOgrenci(int id)
        {
            var ogrencivalues = om.GetByID(id);
            return View(ogrencivalues);
        }

        [HttpPost]
        public ActionResult EditOgrenci(tOgrenci p)
        {
            om.OgrenciUpdate(p);
            return RedirectToAction("GetOgrenci");
        }
    }
}