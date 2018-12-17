using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatFinalni.Models;

namespace ProjekatFinalni.Controllers
{
    public class DodavanjeSkoleController : Controller
    {
        // GET: DodavanjeSkole
        public ActionResult Novi()
        {
            var skola = new Skola();
            var kontakt = new Kontakt();
            skola.NapraviKontakta(1);
            return View(skola);
        }
        [HttpPost]
        public ActionResult Novi(Skola skolica1)
        {
            BazaProjekatEntities bazaSkola = new BazaProjekatEntities();
            if (ModelState.IsValid)
            { 
                bazaSkola.Skolas.Add(skolica1);
                
                
                bazaSkola.SaveChanges();


            }
            return Redirect("Novi");
        }
    }
}