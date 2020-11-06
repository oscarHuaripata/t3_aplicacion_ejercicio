using FinancistoCloneWeb.Models;
using FinancistoCloneWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace FinancistoCloneWeb.Controllers
{
    [Authorize]
    public class RutinaController : BaseController
    {
        private readonly IRutinaService _RutinaService;

        public IHostEnvironment   _hostEnv;
        public RutinaController(FinancistoContext context, IRutinaService RutinaService) :base(context)
        {
            _RutinaService = RutinaService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var account = new  Rutina();
            var accounts = _RutinaService.Lista(LoggedUser().Id);

            return View(accounts);            
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Types = _RutinaService.TipoRutina();
            return View("Create", new Rutina());
        }

        [HttpPost]
        public ActionResult Create(Rutina model, IFormFile image)
        {
            model.UserId = LoggedUser().Id;
            if (ModelState.IsValid)
            {
                if (_RutinaService.CrearRutinaEjercicio(model)) { 
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Types = _RutinaService.TipoRutina();
            return View("Create", model);
        }
    }
}
