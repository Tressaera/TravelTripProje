using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID >= 5).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 5).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var degers = c.Blogs.Take(2).ToList();
            return PartialView(degers);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(2).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.ToList();
            return PartialView(deger);
        }
    }
}