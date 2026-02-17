using OITech.Models.Request;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Linq;
using OITech.Models.Datos;

namespace OITech.Services
{
    public class geoCodificadorService : IgeoCodificadorService
    {
        public void PostgeoCodificador(string dirinput)
        {
            var client = new RestClient("https://catalogopmb.catastrobogota.gov.co/PMBWeb/web/api");
            var request = new RestRequest();
            request.AddParameter("cmd", "geocodificar");
            request.AddParameter("apikey", "e2d6f043-7b63-417e-8fbe-db515898576f");
            request.AddParameter("query", dirinput);
            RestResponse response = client.Execute(request);
            var obj = JsonConvert.DeserializeObject<RootgeoCodificador>(response.Content);
            var item = new TblGeocodificador()
            {
                Estado = obj.response.data.estado,
                Lotcodigo = obj.response.data.lotcodigo,
                Latitude = obj.response.data.latitude,
                Diraprox = obj.response.data.diraprox,
                Mancodigo = obj.response.data.mancodigo,
                Cpocodigo = obj.response.data.cpocodigo,
                Codloc = obj.response.data.codloc,
                Dirtrad = obj.response.data.dirtrad,
                Nomupz = obj.response.data.nomupz,
                Localidad = obj.response.data.localidad,
                Codupz = obj.response.data.codupz,
                Nomseccat = obj.response.data.nomseccat,
                TipoDireccion = obj.response.data.tipo_direccion,
                Codseccat = obj.response.data.codseccat,
                Longitude = obj.response.data.longitude,
                Dirinput = obj.response.data.dirinput,
                Xinput = obj.response.data.xinput,
                Yinput = obj.response.data.yinput,
                InsertionDate = System.DateTime.Now,
                InsertUser = 1,
                UpdateDate = null,
                UpdateUser = null,
                Active = true
            };

            try
            {
                using (OITechContext db = new OITechContext())
                {
                    db.TblGeocodificadors.Add(item);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error en la inserción");
            }
        }

        public string GetLastLotcodigo()
        {
            Response oResponse = new Response();
            string item;
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    var query = (
                        from TblGeocodificador in db.TblGeocodificadors
                        orderby TblGeocodificador.IIdGeocodificador
                        select TblGeocodificador.Lotcodigo)
                        .Take(1);
                    item = query.First();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error consultando ultimo lote");
            }
            return item;
        }
        public string GetLastMancodigo()
        {
            Response oResponse = new Response();
            string item;
            try
            {
                using (OITechContext db = new OITechContext())
                {
                    var query = (
                        from TblGeocodificador in db.TblGeocodificadors
                        orderby TblGeocodificador.IIdGeocodificador
                        select TblGeocodificador.Mancodigo)
                        .Take(1);
                    item = query.First();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error consultando ultima manzana");
            }
            return item;
        }
    }
}
