using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamenFinal.Models;

namespace ExamenFinal.Interfaces
{
    public class ServicioValidar : IValidar
    {
        private ModelStateDictionary modelState;
        public void validarCuenta(Cuenta cuenta, ModelStateDictionary modelState)
        {
            this.modelState = modelState;
            if (cuenta.nombre == null || cuenta.nombre == "")
                modelState.AddModelError("nombre", "La nombre es inválida");
            if (cuenta.categoria == null || cuenta.categoria == "")
                modelState.AddModelError("categoria", "Categoria es invalida");
            if (cuenta.saldoinicial < 0)
                modelState.AddModelError("saldoinicial", "El saldo inicial no  valida");

        }

        public void validarGastos(Gastos gasto, ModelStateDictionary modelState)
        {
            this.modelState = modelState;

            if (gasto.Monto < 0)
                modelState.AddModelError("Monto", "El monto no valido");

            if (gasto.Fecha == null)
                modelState.AddModelError("Fecha", "Fecha Obligatoria");

            if (gasto.Descripcion == null)
                modelState.AddModelError("Descripcion", "Descripcion Obligatoria");
        }

        public void validarIngresos(Ingresos ingresos, ModelStateDictionary modelState)
        {
            this.modelState = modelState;

            if (ingresos.Monto < 0)
                modelState.AddModelError("Monto", "El monto no valido");

            if (ingresos.Fecha == null)
                modelState.AddModelError("Fecha", "Fecha Obligatoria");

            if (ingresos.Descripcion == null)
                modelState.AddModelError("Descripcion", "Descripcion Obligatoria");
        }
        public bool IsValid()
        {
            return modelState.IsValid;
        }
    }
}