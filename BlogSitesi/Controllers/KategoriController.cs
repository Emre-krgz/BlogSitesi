using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    using Models;
    public class KategoriController : Controller
    {
        BlogDbContext context = new BlogDbContext();
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult KategoriWidget()
        {
            return PartialView(context.Kategoris.ToList());
        }
    }
}