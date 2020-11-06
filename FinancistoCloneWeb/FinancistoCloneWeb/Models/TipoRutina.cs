using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.Models
{
    public class TipoRutina
    {
        public int    Id                { get; set; }
        public string Nombre            { get; set; }
        public int    Codigo            { get; set; }
        public int    CantidadSeleccion { get; set; }
    }
}
