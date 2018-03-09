using PierwszaAplikacja1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PierwszaAplikacja1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Test = "Testowa wartosc";
            var kontakty = new List<Kontakt> { new Kontakt { Imie="Jan", Nazwisko="Nowak",Miasto="Łeczna",Ulica="Mickiewicza"},
            new Kontakt{Imie="Grzegorz",Nazwisko="Maksim",Miasto="Lublin",Ulica="Biskupie Kolonia"}};
            ViewBag.Kontakty = kontakty;
            return View();
        }
        //public string Index(string id)
        //{
        //    return "kurs ASP,NET MVC"+id;
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}