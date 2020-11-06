using FinancistoCloneWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb
{
    public class RutinaService : IRutinaService
    {
        private readonly FinancistoContext _context;

        public RutinaService(FinancistoContext context)
        {
            _context = context;
        }

        public Rutina BuscarPorId(int rutinaId)
        {
            return _context.Rutina.First(o => o.RutinaId == rutinaId);
        }

        public bool CrearRutinaEjercicio(Rutina model)
        {
            _context.Rutina.Add(model);
            _context.SaveChanges();

            var seed   = Environment.TickCount;
            var random = new Random(seed);
            var FindTR = _context.TipoRutinas.FirstOrDefault(c=>c.Id == model.TipoRutinaId);
            for (int i = 0; i < FindTR.CantidadSeleccion; i++)
            {
                _context.RutinaEjercicios.Add(new RutinaEjercicio
                {
                    RutinaId    = model.RutinaId,
                    EjercicioId = random.Next(1, 20),
                    duracion    = FindTR.Codigo == 3 ? 120: random.Next(60, 120)
                });
                _context.SaveChanges();
            }

            return true;
        }

        public List<Rutina> Lista(int UserId)
        {
           return _context.Rutina
                .Where(o => o.UserId == UserId)
                .Include(o => o.TipoRutina)
                .ToList();
        }

        public List<TipoRutina> TipoRutina()
        {
           return _context.TipoRutinas.ToList();
        }
    }
}
