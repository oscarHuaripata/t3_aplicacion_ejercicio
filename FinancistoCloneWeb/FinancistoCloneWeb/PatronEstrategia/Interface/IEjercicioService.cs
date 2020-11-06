using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancistoCloneWeb.Models;

namespace FinancistoCloneWeb 
{ 
    public interface IEjercicioService
    {
        List<RutinaEjercicio> Lista(int rutinaId);
    }
}
