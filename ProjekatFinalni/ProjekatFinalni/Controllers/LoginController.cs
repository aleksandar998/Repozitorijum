using ProjekatFinalni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjekatFinalni.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Odobri(ProjekatFinalni.Models.Korisnik korisnikModel)
        {
            using (BazaProjekatEntities3 db = new BazaProjekatEntities3())
            {
                var korisnikPodaci = db.Korisniks.Where(x => x.Korisnickoime == korisnikModel.Korisnickoime && x.Lozinka == korisnikModel.Lozinka).FirstOrDefault();
                if(korisnikPodaci==null)
                {
                    korisnikModel.LoginErrorPoruka = "Pogresno korisnicko ime ili lozinka,molim pokusajte ponovo.";
                    return View("Index", korisnikModel);
                }
                else
                {
                    Session["korisnikID"] = korisnikPodaci.KorisnikID;
                   
                        return RedirectToAction("Index", "Pocetna");
                    
                }
            }
               
        }
    }
}