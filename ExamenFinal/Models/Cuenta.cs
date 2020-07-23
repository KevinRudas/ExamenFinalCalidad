using System;


using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.Models
{
    public class Cuenta
    {
        public int idCuenta { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public double saldoinicial { get; set; }
        public IList<Gastos> Gastos { get; set; }
        public IList<Ingresos> Ingresos { get; set; }

    }
}