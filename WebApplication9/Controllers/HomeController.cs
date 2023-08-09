using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models.Sınıflar;


namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var degerler = db.Endemik_Bitkilers.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            var degerler = db.bitkiDurums.ToList();
            return View(degerler);
        }

        public ActionResult Contact()
        {
            var degerler = db.EkolojikDurums.ToList();

            return View(degerler);
        }
    }
}