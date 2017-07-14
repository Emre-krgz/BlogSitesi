using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    using Models;
    public class HomeController : Controller
    {
        BlogDbContext context = new BlogDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MakaleListele()
        {
            var data = context.Makales.ToList();
            return View("MakaleListeleWidget",data);
        }

        public PartialViewResult SiteHakkinda()
        {
            return PartialView("SiteHakkinda");
        }

        public PartialViewResult PopulerMakalelerWidget()
        {
            var model = context.Makales.OrderByDescending(x => x.EklenmeTarihi).Take(3).ToList();
            return PartialView(model);
    }
    }
}