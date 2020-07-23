using ExamenFinal.Controllers;
using ExamenFinal.Interfaces;
using ExamenFinal.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Pruebas
{
    [TestFixture]
    public class PruebasUnitarias
    {
       
        
            [Test]
            public void CrearCuenta()
            {
            var cuenta = new Cuenta
            {
                idCuenta = 1,
                nombre = "cuentaPropua",
                categoria="propio",
                saldoinicial =12.2
            };
                
                var mocksession = new Mock<ICuenta>();
                mocksession.Setup(o => o.crearCuenta(cuenta));
            var validadcion = new Mock<IValidar>();
            validadcion.Setup(o => o.validarCuenta(cuenta, null));
            validadcion.Setup(o => o.IsValid()).Returns(true);
            var controler = new CuentaController(mocksession.Object, validadcion.Object);
                var view = controler.Crear(cuenta) as RedirectToRouteResult;

                Assert.IsInstanceOf<RedirectToRouteResult>(view);
                mocksession.Verify(o => o.crearCuenta(cuenta), Times.Once);
            }
            [Test]
            public void listarCuenta()
            {
               var mocksession = new Mock<ICuenta>();
                mocksession.Setup(o => o.MostrarCuenta()).Returns(new List<Cuenta>());
                var controler = new CuentaController(mocksession.Object, null);
                var view = controler.Index() as ViewResult;

                Assert.IsInstanceOf<ViewResult>(view);
             mocksession.Verify(o => o.MostrarCuenta(), Times.Once);
            }
        [Test]
        public void crearGastos()
        {
            var gastos = new Gastos
            {
                IdGasto = 1,
                Monto = 23.2,
                Descripcion = "retiro de soles",
                Fecha = new DateTime(2020, 5, 15),
                idCuenta = 1
            };

            var mocksession = new Mock<IGastos>();
            mocksession.Setup(o => o.crearGastos(gastos));

            var validadcion = new Mock<IValidar>();
            validadcion.Setup(o => o.validarGastos(gastos, null));
            validadcion.Setup(o => o.IsValid()).Returns(true);

            var controler = new GastosController(mocksession.Object,validadcion.Object);
                 var view = controler.Crear(gastos) as RedirectToRouteResult;

                 Assert.IsInstanceOf<RedirectToRouteResult>(view);
                mocksession.Verify(o => o.crearGastos(gastos), Times.Once);
            }
        [Test]
        public void crearIngresos()
        {
            var ingresos = new Ingresos
            {
                IdIngresos = 1,
                Monto = 23.2,
                Descripcion = "retiro de soles",
                Fecha = new DateTime(2020, 5, 15),
                idCuentaI = 1
            };

            var mocksession = new Mock<IIngresos>();
            mocksession.Setup(o => o.crearIngresos(ingresos));

            var validadcion = new Mock<IValidar>();
            validadcion.Setup(o => o.validarIngresos(ingresos, null));
            validadcion.Setup(o => o.IsValid()).Returns(true);


            var controler = new IngresosController(mocksession.Object,validadcion.Object);
            var view = controler.Crear(ingresos) as RedirectToRouteResult;

            Assert.IsInstanceOf<RedirectToRouteResult>(view);
            mocksession.Verify(o => o.crearIngresos(ingresos), Times.Once);
        }
    }
}
