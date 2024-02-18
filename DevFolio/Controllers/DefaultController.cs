using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class DefaultController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            var vules = db.TblFeature.ToList();
            return PartialView(vules);
        }
        public PartialViewResult PartialProfile()
        {
            var vules = db.TblProfile.ToList();
            return PartialView(vules);
        }
        public PartialViewResult PartialSkill()
        {
            var vules = db.TblSkill.ToList();
            return PartialView(vules);
        }
    }
}