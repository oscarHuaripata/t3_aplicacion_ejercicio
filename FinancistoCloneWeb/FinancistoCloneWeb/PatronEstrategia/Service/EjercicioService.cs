using FinancistoCloneWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.PatronEstrategia.Service
{
    public class EjercicioService : IEjercicioService
    {
        private readonly FinancistoContext _context;
        public EjercicioService(FinancistoContext context)
        {
            _context = context;
        }

        public List<RutinaEjercicio> Lista(int rutinaId)
        {
            return _context.RutinaEjercicios.Include(c => c.Ejercicio).Include(c => c.Rutina).Include(c => c.Rutina.TipoRutina)
                .Where(o => o.RutinaId == rutinaId)
                .OrderBy(o => o.duracion)
                .ToList();
        }
    }
}
