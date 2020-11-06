using System;
using System.Collections.Generic;
using System.Linq;
using FinancistoCloneWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinancistoCloneWeb.Controllers
{
    [Authorize]
    public class EjercicioController : BaseController
    {
        private readonly IRutinaService     _RutinaService;
        private readonly IEjercicioService  _EjercicioService;

        public EjercicioController(FinancistoContext context,IRutinaService RutinaService, IEjercicioService EjercicioService) : base(context)
        {
            _RutinaService    = RutinaService;
            _EjercicioService = EjercicioService;
        }

        [HttpGet]
        public IActionResult Index(int rutinaId)
        {
            ViewBag.Rutina = _RutinaService.BuscarPorId(rutinaId);
            return View(_EjercicioService.Lista(rutinaId));
        }
    }
}
