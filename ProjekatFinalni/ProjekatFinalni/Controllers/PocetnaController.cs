using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjekatFinalni.Controllers
{
    public class PocetnaController : Controller
    {
        // GET: Pocetna
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SkolaDodavanje()
        {
            return View();
        }
    }
}