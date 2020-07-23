using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Interfaces
{
    public interface ICuenta
    {
        List<Cuenta> MostrarCuenta();
        void crearCuenta(Cuenta cuenta);
    }
}
