using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_267_Web_FIA35_Formular.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string inpVorname, string inpNachname, DateTime inpGeburtstag, string inpGeschlecht,
            string? inpWin, string? inpLinux, string? inpIOs, string? inpAndroid, string? textAreaBemerkungen )
        {
            ViewBag.Vorname = inpVorname;
            ViewBag.Nachname = inpNachname;
            ViewBag.Geburtstag = inpGeburtstag.ToShortDateString();
            ViewBag.Geschlecht = inpGeschlecht;

            List<string> listeBetriebssysteme = new List<string>();
            if (inpWin != null)
            {
                listeBetriebssysteme.Add(inpWin);
            }
            if (inpLinux != null)
            {
                listeBetriebssysteme.Add(inpLinux);
            }
            if (inpIOs != null)
            {
                listeBetriebssysteme.Add(inpIOs);
            }
            if (inpAndroid != null)
            {
                listeBetriebssysteme.Add(inpAndroid);
            }
            ViewBag.ListeBetriebssysteme = listeBetriebssysteme;

            ViewBag.Bemerkungen = textAreaBemerkungen;

            return View();
        }
    }
}
