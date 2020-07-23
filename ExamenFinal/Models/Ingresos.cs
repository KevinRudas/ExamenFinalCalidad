using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.Models
{
    public class Ingresos
    {
        public int IdIngresos { get; set; }
        public double Monto { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public Cuenta Cuenta { get; set; }
        public int idCuentaI { get; set; }
    }
}