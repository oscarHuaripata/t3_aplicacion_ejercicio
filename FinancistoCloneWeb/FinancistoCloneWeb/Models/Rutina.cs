using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.Models
{
    public class Rutina
    {
        public int      RutinaId { get; set; }
        public string   Nombre { get; set; }
        public int      UserId { get; set; }
        public int      TipoRutinaId { get; set; }
        public TipoRutina TipoRutina { get; set; }
    }
}
