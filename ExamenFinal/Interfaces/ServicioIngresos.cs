using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamenFinal.Maps;
using ExamenFinal.Models;

namespace ExamenFinal.Interfaces
{
    public class ServicioIngresos : IIngresos
    {
        public void crearIngresos(Ingresos ingresos)
        {
            var bd = new DBContxt();
            bd.Ingresos.Add(ingresos);
            bd.SaveChanges();
        }
    }
}