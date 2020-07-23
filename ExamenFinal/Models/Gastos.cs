using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.Models
{
    public class Gastos
    {
        public int IdGasto { get; set; }
        public double Monto { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public Cuenta Cuenta { get; set; }
        public int idCuenta { get; set; }
    }
}