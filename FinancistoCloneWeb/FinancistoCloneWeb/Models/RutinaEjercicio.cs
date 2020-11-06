using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinancistoCloneWeb.Models
{
    public class RutinaEjercicio
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal duracion { get; set; }

        public int       EjercicioId { get; set; }
        public Ejercicio Ejercicio { get; set; }


        public int      RutinaId { get; set; }
        public  Rutina  Rutina { get; set; }
    }
}
