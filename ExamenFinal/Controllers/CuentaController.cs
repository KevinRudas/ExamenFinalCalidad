using ExamenFinal.Interfaces;
using ExamenFinal.Maps;
using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenFinal.Controllers
{
    public class CuentaController : Controller
    {
        private ICuenta ic;
        private IValidar iv;
        public CuentaController(ICuenta ic, IValidar iv)
        {
            this.ic = ic;
            this.iv = iv;
        }
        
        public ActionResult Index()
        {
            var DBContext = new DBContxt();
            
                var cuentas = ic.MostrarCuenta();
                return View(cuentas);
            
        }

        [HttpPost]
        public ActionResult Crear(Cuenta cuenta)
        {
            iv.validarCuenta(cuenta, ModelState);
            //Validar(cuenta);
            if (iv.IsValid())
            {
                ic.crearCuenta(cuenta);
                return RedirectToAction("Index");
            }
            return View(cuenta);
        }

        [HttpGet]
        public ActionResult Crear()
        {
            return View(new Cuenta());
        }
        
    }
}
