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
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult EtiketWidger()
        {
            return PartialView(context.Etikets.ToList());
        }

        public ActionResult MakaleListele(int id)
        {
            var data = context.Makales.Where(x => x.MakaleEtikets.Any(y=>y.EtiketId==id)).ToList();
            return View("MakaleListeleWidget", data);
        }
    }
}