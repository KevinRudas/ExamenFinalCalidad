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
    public class GastosController : Controller
    {
        private IGastos ig;
        private IValidar iv;
        public GastosController(IGastos ig, IValidar iv)
        {
            this.ig = ig;
            this.iv = iv;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Gastos gasto)
        {
            var DBContext = new DBContxt();
            ViewBag.Cuentas = DBContext.Cuentas;
            iv.validarGastos(gasto, ModelState);
            if (iv.IsValid())
            {

                ig.crearGastos(gasto);
                return RedirectToActionPermanent("Index", "Cuenta");
            }
            return View("Crear");
        }

        [HttpGet]
        public ActionResult Crear(int idCuenta)
        {
            var DBContext = new DBContxt();
            ViewBag.Cuentas = DBContext.Cuentas.Where(a => a.idCuenta == idCuenta);

            return View(new Gastos());
        }
        

    }
}
