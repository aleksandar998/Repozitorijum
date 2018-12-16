using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatFinalni.Models;

namespace ProjekatFinalni.Controllers
{
    public class SkolaController : Controller
    {
        // GET: Skola
        public ActionResult Index()
        {
            BazaProjekatEntities KontakiBaza = new BazaProjekatEntities();
            List<Skola>skole =KontakiBaza.Skolas.ToList();
            return View(skole);
        }
    }
}