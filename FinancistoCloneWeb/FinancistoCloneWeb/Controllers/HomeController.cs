using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinancistoCloneWeb.Models;
using System.Globalization;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace FinancistoCloneWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly FinancistoContext db;

        public HomeController(ILogger<HomeController> logger, FinancistoContext db)
        {
            this.db = db;
            _logger = logger;
        }     

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {

            if (!db.Users.Any())
            {
                List<User> ItemList = new List<User>
                {
                    new Models.User { Username="osduar",Password="CHtbWNm2i8zfYPYLFS2ru7rH69lVhShO0+A3uAYkaEA="},
                };
                db.Users.AddRange(ItemList);
                db.SaveChanges();
            }

            if (!db.Ejercicios.Any())
            {
                List<Ejercicio> ItemList = new List<Ejercicio>
                {
                    new Models.Ejercicio {Nombre="Ejercicio 1", Link="https://www.youtube.com/watch?v=FNjIUpYz4hs"},
                    new Models.Ejercicio {Nombre="Ejercicio 2", Link="https://www.youtube.com/watch?v=MY_gyv3ZDLE"},
                    new Models.Ejercicio {Nombre="Ejercicio 3", Link="https://www.youtube.com/watch?v=rgAM7bGtazU"},
                    new Models.Ejercicio {Nombre="Ejercicio 4", Link="https://www.youtube.com/watch?v=KxfcndYWRx4"},
                    new Models.Ejercicio {Nombre="Ejercicio 5", Link="https://www.youtube.com/watch?v=iQ3g-gqKe_A"},
                    new Models.Ejercicio {Nombre="Ejercicio 6", Link="https://www.youtube.com/watch?v=7qq9lwEWlP0"},
                    new Models.Ejercicio {Nombre="Ejercicio 7", Link="https://www.youtube.com/watch?v=diFjQVUL7wk"},
                    new Models.Ejercicio {Nombre="Ejercicio 8", Link="https://www.youtube.com/watch?v=QhuMeVnn_qU"},
                    new Models.Ejercicio {Nombre="Ejercicio 9", Link="https://www.youtube.com/watch?v=tzfEOXrFEJs"},
                    new Models.Ejercicio {Nombre="Ejercicio 10", Link="https://www.youtube.com/watch?v=Ap4VyHSwmwg"},
                    new Models.Ejercicio {Nombre="Ejercicio 11", Link="https://www.youtube.com/watch?v=g0z0rqoSmxY"},
                    new Models.Ejercicio {Nombre="Ejercicio 12", Link="https://www.youtube.com/watch?v=gMGEySHegj4"},
                    new Models.Ejercicio {Nombre="Ejercicio 13", Link="https://www.youtube.com/watch?v=mcjMSQCNkbQ"},
                    new Models.Ejercicio {Nombre="Ejercicio 14", Link="https://www.youtube.com/watch?v=bp5sGtLpP1s"},
                    new Models.Ejercicio {Nombre="Ejercicio 15", Link="https://www.youtube.com/watch?v=5FRTNWPWSOA"},
                    new Models.Ejercicio {Nombre="Ejercicio 16", Link="https://www.youtube.com/watch?v=4rNi8bQIdFY"},
                    new Models.Ejercicio {Nombre="Ejercicio 17", Link="https://www.youtube.com/watch?v=u-EWpP5hQpc"},
                    new Models.Ejercicio {Nombre="Ejercicio 18", Link="https://www.youtube.com/watch?v=EuEoM-17xHQ"},
                    new Models.Ejercicio {Nombre="Ejercicio 19", Link="https://www.youtube.com/watch?v=BkxBL5cEu-8"},
                    new Models.Ejercicio {Nombre="Ejercicio 20", Link="https://www.youtube.com/watch?v=nOGxuKwqzrM"},
                };
                db.Ejercicios.AddRange(ItemList);
                db.SaveChanges();
            }

            if (!db.TipoRutinas.Any())
            {
                List<TipoRutina> ItemList = new List<TipoRutina>
                {
                    new Models.TipoRutina { Codigo=1,Nombre="Principiante", CantidadSeleccion=5},
                    new Models.TipoRutina { Codigo=2,Nombre="Intermedio",CantidadSeleccion= 10},
                    new Models.TipoRutina { Codigo=3,Nombre="Avanzado",CantidadSeleccion=15},
                };
                db.TipoRutinas.AddRange(ItemList);
                db.SaveChanges();
            }


            return View();
        }

        [HttpPost]

        public IActionResult Create(Account account)
        {
            if (string.IsNullOrEmpty(account.Name))
                ModelState.AddModelError("Name", "Nombre es requerido");            

            if (ModelState.IsValid)
            {
                //Guardar
                return RedirectToAction("Index");
            }

            return View(account);
            // No guardar
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private static string RemoveAccents(string s)
        {
            Encoding destEncoding = Encoding.GetEncoding("utf-8");

            return destEncoding.GetString(
                Encoding.Convert(Encoding.UTF8, destEncoding, Encoding.UTF8.GetBytes(s)));
        }
    }
}
