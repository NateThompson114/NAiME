using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using NAiME.Models;

namespace NAiME.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        
        [Authorize]
        public ActionResult ChangeLog()
        {
            var viewData = _context.ChangeLogs.ToList();

            return View(viewData);
        }
        
        public ActionResult MyLocalPush()
        {
            return RedirectToAction("Index");
        }
    }
}