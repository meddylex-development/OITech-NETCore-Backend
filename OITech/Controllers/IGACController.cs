using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OITech.Models.Datos;
using OITech.Models.Response;
using OITech.Services.IGAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]

    public class IGACController : ControllerBase
    {
        private readonly InumeroPredialService _numeroPredialService;
        private readonly IcoordenadaService _coordenadaService;
        public IGACController
            (
            InumeroPredialService numeroPredialService,
            IcoordenadaService coordenadaService
            )
        {
            _numeroPredialService = numeroPredialService;
            _coordenadaService = coordenadaService;
        }


        // Consulta por Numero predial
        [HttpPost]
        [Route("ConsultaNumeroPredial")]
        public ActionResult AddConsultaNumerioPredial(string CODIGO, string CEDULACATASTRAL)
        {
            Respuesta oResponse = new Respuesta();
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    _numeroPredialService.PostnumeroPredial(CODIGO, CEDULACATASTRAL);
                    oResponse.Exito = 1;
                    oResponse.Mensaje = "predio con codigo " + CODIGO + ", insertado con éxito";
                }
            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);
        }

        // Consulta por coordenada
        [HttpPost]
        [Route("ConsultaCoordenada")]
        public ActionResult AddConsultaCoordenada(string x, string y)
        {
            Respuesta oResponse = new Respuesta();
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    _coordenadaService.Postcoordenada(x, y);
                    oResponse.Exito = 1;
                    oResponse.Mensaje = "predio con coordenadas x:" + x + " y:" + y + ", insertado con éxito";
                }
            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);
        }

        /*/ Consulta masiva por coordenadas
        [HttpPost]
        [Route("ConsultaMasivaCoordenadas")]
        public ActionResult AddConsultaMasivaCoordenada()
        {
            Respuesta oResponse = new Respuesta();
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    _coordenadaService.GetCoordenadas();
                    oResponse.Exito = 1;
                    oResponse.Mensaje = "predios en masa, insertados con éxito";
                }
            }
            catch (Exception ex)
            {
                oResponse.Mensaje = ex.Message;
            }
            return Ok(oResponse);
        }*/
    }
}
