using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OITech.Services.SNR;
using Microsoft.AspNetCore.Authorization;
using OITech.Models.Response;
using OITech.Models.Datos;

namespace OITech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

        public class SNRController : ControllerBase
        {
            private readonly ImatriculaService _matriculaService;
            public SNRController
                (
                ImatriculaService matriculaService
                )
            {
                _matriculaService = matriculaService;
            }


            // Consulta por Numero de matricula
            [HttpPost]
            [Route("ConsultaNumeroMatricula")]
            public ActionResult AddConsultaNumerioMatricula(string Oficina, string Numero)
            {
                Respuesta oResponse = new Respuesta();
                try
                {
                    using (OITechContext db = new OITechContext())
                    {
                        string item =_matriculaService.matriculaInmobiliara(Oficina, Numero);
                    if (item[0] == '0')
                    {
                        oResponse.Exito = 0;
                        oResponse.Mensaje = "Error de validacion matricula";
                        oResponse.Data = item;
                    }
                    else
                    {
                        oResponse.Exito = 1;
                        oResponse.Mensaje = "matricula " + Oficina + "-" + Numero + " consultada con éxito";
                        oResponse.Data = item;
                    }
                }
                }
                catch (Exception ex)
                {
                    oResponse.Mensaje = ex.Message;
                }
                return Ok(oResponse);
            }

        // Comprar matricula
        [HttpPost]
        [Route("ComprarMatricula")]
        public ActionResult AddComprarMatricula(string Oficina, string Numero, string user, string pass)
        {
            Respuesta oResponse = new Respuesta();
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    string item = _matriculaService.compraMatriculaInmobiliara(Oficina, Numero, user, pass);
                    oResponse.Exito = 1;
                    oResponse.Mensaje = "matricula " + Oficina + "-" + Numero + " comprada con éxito";
                    oResponse.Data = item;
                }
            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);
        }

        // descarga certifad
        [HttpPost]
        [Route("BuscarMatriculaComprada")]
        public ActionResult AddBuscarMatricula(string Numero, string user, string pass)
        {
            Respuesta oResponse = new Respuesta();
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    string item = _matriculaService.buscarMatriculaInmobiliaraComprada(Numero, user, pass);
                    oResponse.Exito = 1;
                    oResponse.Mensaje = "link de la matricula " + Numero + " generado con exito";
                    oResponse.Data = item;
                }
            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);
        }

        // Consultar saldo
        [HttpPost]
        [Route("ConsultarSaldo")]
        public ActionResult AddConsultarSaldo(string user, string pass)
        {
            Respuesta oResponse = new Respuesta();
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    string item = _matriculaService.consultarSaldo(user, pass);
                    oResponse.Exito = 1;
                    oResponse.Mensaje = "saldo consultao con exito";
                    oResponse.Data = item;
                }
            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);
        }

    }
}

