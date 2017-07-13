using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    using Models;
    public class EtiketController : Controller
    {
        BlogDbContext context = new BlogDbContext();
        // GET: Etiket
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult EtiketWidger()
        {
            return PartialView(context.Etikets.ToList());
        }
    }
}