using ExamenFinal.Interfaces;
using ExamenFinal.Maps;
using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenFinal.Controllers
{
    public class IngresosController : Controller
    {

        private IIngresos igre;
        private IValidar iv;
        public IngresosController( IIngresos igre, IValidar iv)
        {
            this.igre = igre;
            this.iv = iv;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Ingresos ingresos)
        {
            var DBContext = new DBContxt();
            ViewBag.Cuentas = DBContext.Cuentas;
            iv.validarIngresos(ingresos, ModelState);
            if (iv.IsValid())
            {

                igre.crearIngresos(ingresos);
                return RedirectToActionPermanent("Index", "Cuenta");
            }
            return View("Crear");
        }

        [HttpGet]
        public ActionResult Crear(int idCuenta)
        {
            var DBContext = new DBContxt();
            ViewBag.Cuentas = DBContext.Cuentas.Where(a => a.idCuenta == idCuenta);

            return View(new Ingresos());
        }
        
    }
}