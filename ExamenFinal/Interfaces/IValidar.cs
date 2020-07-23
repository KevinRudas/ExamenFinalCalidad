using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ExamenFinal.Interfaces
{
    public interface IValidar
    {
        void validarCuenta(Cuenta cuenta, ModelStateDictionary modelState );
        void validarGastos(Gastos gasto, ModelStateDictionary modelState);
        void validarIngresos(Ingresos ingresos, ModelStateDictionary modelState);
        bool IsValid();
    }
}
