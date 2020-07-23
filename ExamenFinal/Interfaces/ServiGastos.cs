using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ExamenFinal.Maps;
using ExamenFinal.Models;

namespace ExamenFinal.Interfaces
{
    public class ServiGastos : IGastos
    {
        public void crearGastos(Gastos gasto)
        {
            var bd = new DBContxt();
            bd.Gastos.Add(gasto);
            bd.SaveChanges();
        }
    }
}