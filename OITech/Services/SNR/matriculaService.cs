using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace OITech.Services.SNR
{
    public class MatriculaInfo
    {
        public string Direccion { get; set; }
        public string Circuito { get; set; }
        public string Estado { get; set; }
    }
    public class MensajeError
    {
        public string Mensaje { get; set; }
    }
    public class SaldoCuenta
    {
        public string SaldoActual { get; set; }
        public string EstadoCuenta { get; set; }
        public string UltimoMovimiento { get; set; }
    }
    public class LinkDescarga
    {
        public string Link { get; set; }
    }

    public class matriculaService : ImatriculaService
    {
        public string matriculaInmobiliara(string Oficina, string Numero)
        {
            // Inicializar el driver de Chrome
            IWebDriver driver = new ChromeDriver();

            // Navegar a la URL
            driver.Navigate().GoToUrl("https://certificados.supernotariado.gov.co/certificado");

            // Esperar a que el campo de entrada de oficinas esté presente y visible
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement input1 = driver.FindElement(By.Id("formOficinas:autoCompleteOficinas_input"));

            // Ingresar el valor en el campo de entrada de oficinas
            input1.SendKeys(Oficina);
            Thread.Sleep(1000);
            input1.SendKeys(Keys.Tab);

            // Encontrar el campo de entrada de matrícula y enviar el valor
            IWebElement input3 = driver.FindElement(By.Id("formOficinas:inpMatricula"));
            input3.SendKeys(Numero);

            // Encontrar el botón de búsqueda y hacer clic en él
            IWebElement btnsearch = driver.FindElement(By.Id("formOficinas:btnBuscar"));
            btnsearch.Click();

            // Guardar datos
            Thread.Sleep(4000);
            string json;

            if (driver.FindElement(By.Id("modalDialog")).Displayed)
            {
                IWebElement Mensaje = driver.FindElement(By.CssSelector("#modalDialog > div.ui-dialog-content.ui-widget-content > div:nth-child(1) > span > div"));
                Console.WriteLine(Mensaje.Text);
                string mensajeText = Mensaje.Text;


                // Crear objeto Mensaje y asignar valores
                MensajeError info = new MensajeError
                {
                    Mensaje = mensajeText
                };

                // Serializar objeto a JSON
                json = "0-"+JsonConvert.SerializeObject(info);
                Console.WriteLine(json);
            }
            else
            {
                IWebElement Direccion = driver.FindElement(By.CssSelector("#formModalMatriculaCarrito > table > tbody > tr:nth-child(2) > td > span"));
                Console.WriteLine(Direccion.Text);
                string direccionText = Direccion.Text;
                IWebElement Circuito = driver.FindElement(By.CssSelector("#formModalMatriculaCarrito > table > tbody > tr:nth-child(4) > td > span"));
                Console.WriteLine(Circuito.Text);
                string circuitoText = Circuito.Text;
                IWebElement Estado = driver.FindElement(By.CssSelector("#formModalMatriculaCarrito > table > tbody > tr:nth-child(6) > td > span"));
                Console.WriteLine(Estado.Text);
                string estadoText = Estado.Text;

                // Crear objeto MatriculaInfo y asignar valores
                MatriculaInfo info = new MatriculaInfo
                {
                    Direccion = direccionText,
                    Circuito = circuitoText,
                    Estado = estadoText
                };

                // Serializar objeto a JSON
                json = JsonConvert.SerializeObject(info);
                Console.WriteLine(json);
            }

            // Cerrar el navegador
            driver.Quit();

            // Retornar el objeto JSON
            return json;
        }

        public string compraMatriculaInmobiliara(string Oficina, string Numero, string user, string pass)
        {
            // Inicializar el driver de Chrome
            IWebDriver driver = new ChromeDriver();

            // Navegar a la URL
            driver.Navigate().GoToUrl("https://certificados.supernotariado.gov.co/certificado");

            // Encontrar el botón de iniciar sesion
            IWebElement btninicio = driver.FindElement(By.Id("j_idt15"));
            btninicio.Click();

            // Esperar a que el campo de entrada de usuario y contraseña esté presente y visible
            Thread.Sleep(1000);

            // Ingresar los valores de usuario y contraseña
            IWebElement input1 = driver.FindElement(By.Id("formLogin:inpUserLogin"));
            input1.SendKeys(user);
            IWebElement input2 = driver.FindElement(By.Id("formLogin:inpPassLogin"));
            input2.SendKeys(pass);

            // Encontrar el botón de ingresar
            IWebElement btningresar = driver.FindElement(By.Id("formLogin:btnIngresarLogin"));
            btningresar.Click();
            Thread.Sleep(1000);

            // Encontrar el botón certificado
            IWebElement btnCertificado = driver.FindElement(By.Id("linkGenerarCTL"));
            btnCertificado.Click();

            // Ingresar el valor en el campo de entrada de oficinas
            IWebElement input3 = driver.FindElement(By.Id("formGeneracionCertificados:indiceMatricula"));
            input3.SendKeys(Keys.LeftShift + Keys.Home);
            input3.SendKeys(Oficina);
            input3.SendKeys(Keys.Tab);
            Thread.Sleep(1000);

            // Ingresar el valor en el campo de entrada de numero
            IWebElement input4 = driver.FindElement(By.Id("formGeneracionCertificados:inpMatricula"));
            input4.SendKeys(Numero);

            // Encontrar el botón de búsqueda
            IWebElement btnsearch1 = driver.FindElement(By.Id("formGeneracionCertificados:btnBuscarMatricula"));
            btnsearch1.Click();
            Thread.Sleep(5000);

            // Encontrar el botón de agregar al carrito
            IWebElement btnagregar = driver.FindElement(By.Id("formModalCarrito:btnAgregarCarrito"));
            btnagregar.Click();
            Thread.Sleep(3000);

            // Encontrar el botón de aceptar
            IWebElement btnaceptar = driver.FindElement(By.Id("frmClosePopup:closePopupButton"));
            btnaceptar.Click();
            Thread.Sleep(3000);

            // Encontrar el botón de pagar
            IWebElement btnpagar = driver.FindElement(By.Id("formGeneracionCertificados:btnPagar"));
            btnpagar.Click();
            Thread.Sleep(3000);

            // Encontrar el botón de confirmacion
            IWebElement btnSi = driver.FindElement(By.Id("j_idt185"));
            btnSi.Click();
            Thread.Sleep(3000);

            // Encontrar el botón cuenta prepago
            IWebElement btnPrepago = driver.FindElement(By.Id("formPayment:medioPago6"));
            btnPrepago.Click();
            Thread.Sleep(3000);


            // Encontrar el botón de realizar el pago
            IWebElement btnPago = driver.FindElement(By.Id("formModalInformacionPago:btnRealizarPago"));
            btnPago.Click();
            Thread.Sleep(5000);

            // Cerrar el navegador
            driver.Quit();

            // Retornar con exito
            return "Exito";
        }

        public string buscarMatriculaInmobiliaraComprada(string Numero, string user, string pass)
        {
            // Inicializar el driver de Chrome
            IWebDriver driver = new ChromeDriver();

            // Navegar a la URL
            driver.Navigate().GoToUrl("https://certificados.supernotariado.gov.co/certificado");

            // Encontrar el botón de iniciar sesion
            IWebElement btninicio = driver.FindElement(By.Id("j_idt15"));
            btninicio.Click();

            // Esperar a que el campo de entrada de usuario y contraseña esté presente y visible
            Thread.Sleep(1000);

            // Ingresar los valores de usuario y contraseña
            IWebElement input1 = driver.FindElement(By.Id("formLogin:inpUserLogin"));
            input1.SendKeys(user);
            IWebElement input2 = driver.FindElement(By.Id("formLogin:inpPassLogin"));
            input2.SendKeys(pass);

            // Encontrar el botón de ingresar
            IWebElement btningresar = driver.FindElement(By.Id("formLogin:btnIngresarLogin"));
            btningresar.Click();
            Thread.Sleep(1000);

            // Encontrar el botón historial
            IWebElement btnCertificado = driver.FindElement(By.Id("linkHistorial"));
            btnCertificado.Click();

            // Ingresar la matricula a buscar
            IWebElement input3 = driver.FindElement(By.Id("formHistory:inputValor"));
            input3.SendKeys(Numero);

            // Encontrar el botón buscar
            IWebElement btnBuscar = driver.FindElement(By.Id("formHistory:j_idt43"));
            btnBuscar.Click();
            Thread.Sleep(1000);

            // Encontrar link descarga
            IWebElement linkDescarga = driver.FindElement(By.XPath("html/body/div[2]/div[2]/div[2]/form/div/div[2]/div[1]/table/tbody/tr[1]/td[10]/a"));
            Console.WriteLine(linkDescarga.GetAttribute("href"));
            string linkText = linkDescarga.GetAttribute("href");

            // Crear objeto Link Descarga
            LinkDescarga info = new LinkDescarga
            {
                Link = linkText,
            };

            // Serializar objeto a JSON
            string json = JsonConvert.SerializeObject(info);
            Console.WriteLine(json);

            // Cerrar el navegador
            driver.Quit();

            return json;

        }

        public string consultarSaldo(string user, string pass)
            {
                // Inicializar el driver de Chrome
                IWebDriver driver = new ChromeDriver();

                // Navegar a la URL
                driver.Navigate().GoToUrl("https://certificados.supernotariado.gov.co/certificado");

                // Encontrar el botón de iniciar sesion
                IWebElement btninicio = driver.FindElement(By.Id("j_idt15"));
                btninicio.Click();

                // Esperar a que el campo de entrada de usuario y contraseña esté presente y visible
                Thread.Sleep(1000);

                // Ingresar los valores de usuario y contraseña
                IWebElement input1 = driver.FindElement(By.Id("formLogin:inpUserLogin"));
                input1.SendKeys(user);
                IWebElement input2 = driver.FindElement(By.Id("formLogin:inpPassLogin"));
                input2.SendKeys(pass);

                // Encontrar el botón de ingresar
                IWebElement btningresar = driver.FindElement(By.Id("formLogin:btnIngresarLogin"));
                btningresar.Click();
                Thread.Sleep(1000);

                // Encontrar el botón cuenta prepago
                IWebElement btnCertificado = driver.FindElement(By.Id("j_idt150:j_idt151"));
                btnCertificado.Click();

                // Guardar datos
                Thread.Sleep(3000);
                IWebElement SaldoAcual = driver.FindElement(By.CssSelector("#formModalCuentaPrepago > div:nth-child(2) > table > tbody > tr:nth-child(1) > td:nth-child(2) > span"));
                Console.WriteLine(SaldoAcual.Text);
                string saldoAcualText = SaldoAcual.Text;
                IWebElement EstadoCuenta = driver.FindElement(By.CssSelector("#formModalCuentaPrepago > div:nth-child(2) > table > tbody > tr:nth-child(2) > td:nth-child(2) > span"));
                Console.WriteLine(EstadoCuenta.Text);
                string estadoCuentaText = EstadoCuenta.Text;
                IWebElement UltimoMovimiento = driver.FindElement(By.CssSelector("#formModalCuentaPrepago > div:nth-child(2) > table > tbody > tr:nth-child(3) > td:nth-child(2) > span"));
                Console.WriteLine(UltimoMovimiento.Text);
                string ultimoMovimientoText = UltimoMovimiento.Text;

            // Crear objeto SaldoCuenta y asignar valores
            SaldoCuenta info = new SaldoCuenta
            {
                SaldoActual = saldoAcualText,
                EstadoCuenta = estadoCuentaText,
                UltimoMovimiento = ultimoMovimientoText
            };

            // Serializar objeto a JSON
            string json = JsonConvert.SerializeObject(info);
            Console.WriteLine(json);

            // Cerrar el navegador
            driver.Quit();

            // Retornar el objeto JSON
            return json;
            }

    }
}
