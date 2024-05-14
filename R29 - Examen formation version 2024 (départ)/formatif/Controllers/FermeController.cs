using formatif.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formatif.Controllers
{
    public class FermeController : Controller
    {
        private BaseDeDonnees DB;

        public FermeController(BaseDeDonnees dB)
        {
            DB = dB;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enclos()
        {
            ViewBag.Enclos = "Fardoche prendra la relève !";
            return View(DB.Animaux.ToList());
        }

        public IActionResult Maison()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Animal animal)
        {
            try
            {
                animal.Id = DB.Animaux.Max(a => a.Id) + 1;

                // Ajouter l'animal à la base de données
                DB.Animaux.Add(animal);

              return RedirectToAction("Enclos"); // Changer pour une redirection
            }
            catch
            {
                return View();
            }
        }
    }
}
