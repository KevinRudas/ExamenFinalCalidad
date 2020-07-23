using ExamenFinal.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenFinal.Controllers
{
    public class CuentaGastoController : Controller
    {
        // GET: CuentaGasto
        [HttpGet]
        public ActionResult Crear()
        {
            /*var DBContext = new DBContxt();

            ViewBag.Tarjetas = DBContext.Cuentas.ToList();
            ViewBag.Gastos = DBContext.Gastos.ToList();*/

            return View();
        }

    }
}
