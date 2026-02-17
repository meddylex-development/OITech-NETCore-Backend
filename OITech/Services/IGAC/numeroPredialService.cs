using Newtonsoft.Json;
using OITech.Models.Request.IGAC;
using OITech.Models.Datos;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Services.IGAC
{
    public class numeroPredialService : InumeroPredialService
    {
        public void PostnumeroPredial(string CODIGO, string CEDULACATASTRAL)
        {
            var client = new RestClient("https://serviciosgeovisor.igac.gov.co:8080/Geovisor/catastral");
            var request = new RestRequest();
            request.AddParameter("cmd", "query_codigo");
            var epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            request.AddParameter("t", epoch);
            request.AddParameter("query", CODIGO);
            RestResponse response = client.Execute(request);
            var obj = JsonConvert.DeserializeObject<RootnumeroPredial>(response.Content);
            Guid Id = Guid.NewGuid();

            var unidad = new Tblunidad()
            {
                UniIdunidad = Id,
                NvaTipo = obj.response.unidad.TIPO,
                NvaCodigo = obj.response.unidad.CODIGO,
                NvaIdUnidadGeo = obj.response.unidad.ID_UNIDAD_GEO,
                NvaNombreCompleto = obj.response.unidad.NOMBRE_COMPLETO,
                NvaNombre = obj.response.unidad.NOMBRE,
                NvaObservacion = null,
                FloFechaInsercion = epoch,
                UniUsuarioInsercion = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                FloFechaModificacion = null,
                UniUsuarioModificacion = null,
                IntActivo = 1,
            };
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    db.Tblunidads.Add(unidad);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error en la inserción de la Unidad");
            }

            var predio = new Tblpredio1()
            {
                Uniunidad = Id,
                FloareaConstruccion = obj.response.predio.areaConstruccion,
                NvanumPredial = obj.response.predio.numPredial,
                NvacodDestino = obj.response.predio.codDestino,
                FloareaTerreno = obj.response.predio.areaTerreno,
                Nvaavaluo = obj.response.predio.avaluo,
                Nvadireccion = obj.response.predio.direccion,
                NvacodDpto = obj.response.predio.codDpto,
                NvanumPredialAnterior = obj.response.predio.numPredialAnterior,
                NvacodMpio = obj.response.predio.codMpio,
                NvaObservacion = null,
                FloFechaInsercion = epoch,
                UniUsuarioInsercion = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00"),
                FloFechaModificacion = null,
                UniUsuarioModificacion = null,
                IntActivo = 1,
            };
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    db.Tblpredios1.Add(predio);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error en la inserción del predio");
            }
        }
    }
}
