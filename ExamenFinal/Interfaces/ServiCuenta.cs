using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ExamenFinal.Maps;
using ExamenFinal.Models;

namespace ExamenFinal.Interfaces
{
    public class ServiCuenta : ICuenta
    {
        public void crearCuenta(Cuenta cuenta)
        {
            var DBContext = new DBContxt();
            DBContext.Cuentas.Add(cuenta);
            DBContext.SaveChanges();
        }

        public List<Cuenta> MostrarCuenta()
        {
            var DBContext = new DBContxt();

            return DBContext.Cuentas.Include(a => a.Gastos).Include(a=>a.Ingresos).ToList();
        }
    }
}