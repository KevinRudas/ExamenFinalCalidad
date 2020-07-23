using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pruebas
{

    [TestFixture]
    public class Selenium
    {
        [Test]
        public void MostrarCuenta()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:57398/Cuenta/Index";

            chromeDriver.FindElementById("idCrear").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            
        }
        [Test]
        public void CrearCuenta()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:57398/Cuenta/Index";

            chromeDriver.FindElementById("idCrear").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.FindElementById("idNombre").SendKeys("Mi continental");
            chromeDriver.FindElementById("idCategoria").Click();
            chromeDriver.FindElementById("idSaldo").SendKeys("3000");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("idGuardar").Click();

        }
        [Test]
        public void crearGasto()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:57398/Cuenta/Index";

            chromeDriver.FindElementById("idGasto").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.FindElementById("idMonto").SendKeys("200");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("idFecha").SendKeys("20-08-2020");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("idDescripcion").SendKeys("Gasto de upn");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("idCuenta").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("idGuardar").Click();

        }
        [Test]
        public void crearIngresos()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:57398/Cuenta/Index";

            chromeDriver.FindElementById("idIngresos").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.FindElementById("idMonto").SendKeys("200");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("idFecha").SendKeys("20-08-2020");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("idDescripcion").SendKeys("Gasto de upn");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("idCuenta").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("idGuardar").Click();

        }
    }
}
