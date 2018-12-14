using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatFinalni.Models;

namespace ProjekatFinalni.Controllers
{
    public class KorisnickiController : Controller
    {
        // GET: Korisnicki
        Korisnik kmodel = new Korisnik();
        public ActionResult DodajiliIzmeni(int id = 0)
        {
            return View(kmodel);
        }

        [HttpPost]
        public ActionResult DodajiliIzmeni(Korisnik korisnikmodel)
        {
            using (BazaProjekatEntities2 Modelkorisnik = new BazaProjekatEntities2())
            {
                Modelkorisnik.Korisniks.Add(korisnikmodel);
                Modelkorisnik.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registracija je uspela";

            return View("DodajiliIzmeni", new Korisnik());
        }

    }
}