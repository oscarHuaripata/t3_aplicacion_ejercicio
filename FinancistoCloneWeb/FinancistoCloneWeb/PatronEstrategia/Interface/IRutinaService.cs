using FinancistoCloneWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace FinancistoCloneWeb
{
    public interface IRutinaService
    {
        bool             CrearRutinaEjercicio(Rutina rutina);
        List<Rutina>     Lista(int UserId);
        List<TipoRutina> TipoRutina();
        Rutina           BuscarPorId(int rutinaId);
    }
}
