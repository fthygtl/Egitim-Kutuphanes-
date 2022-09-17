using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sanayi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult Egitimler()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }

        public ActionResult SSS()
        {
            return View();
        }

        public ActionResult Tezler()
            {
            return View();
        }
        public ActionResult results()
        {
            return View();
        }
    }

    public class AdminController : Controller
    {
        public ActionResult Girisyap()
        {
            return View();
        }
    }
}