using OITech.Models.Response;
using OITech.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;
using OITech.Models.Datos;

namespace OITech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class IdecaController : ControllerBase
    {
        private readonly IgeoCodificadorService _geoCodificadorService;
        private readonly IcatastroLoteService _catastroLoteService;
        private readonly IavaluoCatastralService _avaluoCatastralService;
        private readonly IavaluoComercialService _avaluoComercialService;
        public IdecaController
            (
            IgeoCodificadorService geoCodificadorService,
            IcatastroLoteService catastroLoteService,
            IavaluoCatastralService avaluoCatastralService,
            IavaluoComercialService avaluoComercialService
            )
        {
            _geoCodificadorService = geoCodificadorService;
            _catastroLoteService = catastroLoteService;
            _avaluoCatastralService = avaluoCatastralService;
            _avaluoComercialService = avaluoComercialService;
        }

        // Consulta por direccion
        [HttpPost]
        [Route("ConsultaDireccion")]
        public ActionResult AddConsultaDireccion(string direccion)
        {
            Respuesta oResponse = new Respuesta();
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    _geoCodificadorService.PostgeoCodificador(direccion);
                    string LOTCODIGO = _geoCodificadorService.GetLastLotcodigo();
                    _catastroLoteService.GetLote(LOTCODIGO);
                    _catastroLoteService.GetEstratoSocioeconomico(LOTCODIGO);
                    _catastroLoteService.GetUso(LOTCODIGO);
                    _catastroLoteService.GetPredio(LOTCODIGO);
                    string MANCODIGO = _geoCodificadorService.GetLastMancodigo();
                    _avaluoCatastralService.GetIntegralPH(MANCODIGO);
                    _avaluoCatastralService.GetTerrenoNPH(MANCODIGO);
                    _avaluoComercialService.GetIntegralPH(MANCODIGO);
                    _avaluoComercialService.GetTerrenoNPH(MANCODIGO);




                    oResponse.Exito = 1;
                    oResponse.Mensaje = "Direccion " + direccion + " insertada con éxito";
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
