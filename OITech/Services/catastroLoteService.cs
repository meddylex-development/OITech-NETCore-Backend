using Newtonsoft.Json;
using RestSharp;
using System;
using System.Linq;
using static OITech.Models.Request.catastroLote;
using static OITech.Models.Request.catastroLoteEstratoSocioeconomico;
using static OITech.Models.Request.catastroLotePredio;
using static OITech.Models.Request.catastroLoteUso;
using OITech.Models.Datos;

namespace OITech.Services
{
    public class catastroLoteService : IcatastroLoteService
    {
        //Servicio Get Lote
        public void GetLote(string LOTCODIGO)
        {
            var client = new RestClient("https://serviciosgis.catastrobogota.gov.co/arcgis/rest/services/catastro/lote/MapServer/0/query");
            var request = new RestRequest();
            request.AddParameter("where", "LOTCODIGO LIKE '" + LOTCODIGO + "'");
            request.AddParameter("geometryType", "esriGeometryEnvelope");
            request.AddParameter("spatialRel", "esriSpatialRelIntersects");
            request.AddParameter("units", "esriSRUnit_Foot");
            request.AddParameter("outFields", "*");
            request.AddParameter("returnGeometry", "false");
            request.AddParameter("returnTrueCurves", "false");
            request.AddParameter("returnIdsOnly", "false");
            request.AddParameter("returnCountOnly", "false");
            request.AddParameter("returnZ", "false");
            request.AddParameter("returnM", "false");
            request.AddParameter("returnDistinctValues", "false");
            request.AddParameter("returnExtentOnly", "false");
            request.AddParameter("featureEncoding", "esriDefault");
            request.AddParameter("f", "pjson");
            RestResponse response = client.Execute(request);
            var obj = JsonConvert.DeserializeObject<RootcatastroLote>(response.Content);
            var item = new Tbllote();
            int total = obj.features.Count();
            using (OITechContext db = new OITechContext())
            {
                try
                {
                    for (int i = 0; i < total; i++)
                    {
                        item = new Tbllote()
                        {
                            Lotcodigo = obj.features[i].attributes.LOTCODIGO,
                            Lotdispers = obj.features[i].attributes.LOTDISPERS,
                            Lotildispe = obj.features[i].attributes.LOTILDISPE,
                            Lotupredia = obj.features[i].attributes.LOTUPREDIA,
                            Lotdistrit = obj.features[i].attributes.LOTDISTRIT,
                            Manzcodigo = obj.features[i].attributes.MANZCODIGO,
                            Objectid = obj.features[i].attributes.OBJECTID,
                            Shape = "Envelope",
                            Globalid = obj.features[i].attributes.GLOBALID,
                            Observations = null,
                            InsertionDate = System.DateTime.Now,
                            InsertUser = 1,
                            UpdateDate = null,
                            UpdateUser = null,
                            Active = true
                        };
                        db.Tbllotes.Add(item);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("La insercion del lote ha generado un error");
                }
            }
        }

        //Servicio Get Estrato socio economico
        public void GetEstratoSocioeconomico(string ESOCLOTE)
        {
            var client = new RestClient("https://serviciosgis.catastrobogota.gov.co/arcgis/rest/services/catastro/lote/MapServer/1/query");
            var request = new RestRequest();
            request.AddParameter("where", "ESOCLOTE LIKE '" + ESOCLOTE + "'");
            request.AddParameter("geometryType", "esriGeometryEnvelope");
            request.AddParameter("spatialRel", "esriSpatialRelIntersects");
            request.AddParameter("units", "esriSRUnit_Foot");
            request.AddParameter("outFields", "*");
            request.AddParameter("returnGeometry", "false");
            request.AddParameter("returnTrueCurves", "false");
            request.AddParameter("returnIdsOnly", "false");
            request.AddParameter("returnCountOnly", "false");
            request.AddParameter("returnZ", "false");
            request.AddParameter("returnM", "false");
            request.AddParameter("returnDistinctValues", "false");
            request.AddParameter("returnExtentOnly", "false");
            request.AddParameter("featureEncoding", "esriDefault");
            request.AddParameter("f", "pjson");
            RestResponse response = client.Execute(request);
            var obj = JsonConvert.DeserializeObject<RootcatastroLoteEstratoSocioeconomico>(response.Content);
            var item = new TblloteEstratoSocioeconomico();
            int total = obj.features.Count();

            using (OITechContext db = new OITechContext())
            {
                try
                {
                    for (int i = 0; i < total; i++)
                    {
                        item = new TblloteEstratoSocioeconomico()
                        {
                            Objectid = obj.features[i].attributes.OBJECTID,
                            Esoclote = obj.features[i].attributes.ESOCLOTE,
                            Esochip = obj.features[i].attributes.ESOCHIP,
                            Esoestrato = obj.features[i].attributes.ESOESTRATO,
                            Observations = null,
                            InsertionDate = System.DateTime.Now,
                            InsertUser = 1,
                            UpdateDate = null,
                            UpdateUser = null,
                            Active = true
                        };
                        db.TblloteEstratoSocioeconomicos.Add(item);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("La insercion del Estrato Socio Economico ha generado un error");
                }
            }
        }

        //Servicio Get Uso
        public void GetUso(string USOCLOTE)
        {
            var client = new RestClient("https://serviciosgis.catastrobogota.gov.co/arcgis/rest/services/catastro/lote/MapServer/2/query");
            var request = new RestRequest();
            request.AddParameter("where", "USOCLOTE LIKE '" + USOCLOTE + "'");
            request.AddParameter("geometryType", "esriGeometryEnvelope");
            request.AddParameter("spatialRel", "esriSpatialRelIntersects");
            request.AddParameter("units", "esriSRUnit_Foot");
            request.AddParameter("outFields", "*");
            request.AddParameter("returnGeometry", "false");
            request.AddParameter("returnTrueCurves", "false");
            request.AddParameter("returnIdsOnly", "false");
            request.AddParameter("returnCountOnly", "false");
            request.AddParameter("returnZ", "false");
            request.AddParameter("returnM", "false");
            request.AddParameter("returnDistinctValues", "false");
            request.AddParameter("returnExtentOnly", "false");
            request.AddParameter("featureEncoding", "esriDefault");
            request.AddParameter("f", "pjson");
            RestResponse response = client.Execute(request);
            var obj = JsonConvert.DeserializeObject<RootcatastroLoteUso>(response.Content);
            var item = new TblloteUso();
            int total = obj.features.Count();

            using (OITechContext db = new OITechContext())
            {
                try
                {
                    for (int i = 0; i < total; i++)
                    {
                        item = new TblloteUso()
                        {
                            Objectid = obj.features[i].attributes.OBJECTID,
                            Usoclote = obj.features[i].attributes.USOCLOTE,
                            Usotuso = obj.features[i].attributes.USOTUSO,
                            Usoarea = obj.features[i].attributes.USOAREA,
                            Observations = null,
                            InsertionDate = System.DateTime.Now,
                            InsertUser = 1,
                            UpdateDate = null,
                            UpdateUser = null,
                            Active = true
                        };
                        db.TblloteUsos.Add(item);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("La insercion de Usos ha generado un error");
                }
            }
        }

        //Servicio Get Predio
        public void GetPredio(string BARMANPRE)
        {
            var client = new RestClient("https://serviciosgis.catastrobogota.gov.co/arcgis/rest/services/catastro/lote/MapServer/3/query");
            var request = new RestRequest();
            request.AddParameter("where", "BARMANPRE LIKE '" + BARMANPRE + "'");
            request.AddParameter("geometryType", "esriGeometryEnvelope");
            request.AddParameter("spatialRel", "esriSpatialRelIntersects");
            request.AddParameter("units", "esriSRUnit_Foot");
            request.AddParameter("outFields", "*");
            request.AddParameter("returnGeometry", "false");
            request.AddParameter("returnTrueCurves", "false");
            request.AddParameter("returnIdsOnly", "false");
            request.AddParameter("returnCountOnly", "false");
            request.AddParameter("returnZ", "false");
            request.AddParameter("returnM", "false");
            request.AddParameter("returnDistinctValues", "false");
            request.AddParameter("returnExtentOnly", "false");
            request.AddParameter("featureEncoding", "esriDefault");
            request.AddParameter("f", "pjson");
            RestResponse response = client.Execute(request);
            var obj = JsonConvert.DeserializeObject<RootcatastroLotePredio>(response.Content);
            var item = new TbllotePredio();
            int total = obj.features.Count();

            using (OITechContext db = new OITechContext())
            {
                try
                {
                    for (int i = 0; i < total; i++)
                    {
                        item = new TbllotePredio()
                        {
                            Objectid = obj.features[i].attributes.OBJECTID,
                            Precbarrio = obj.features[i].attributes.PRECBARRIO,
                            Prenbarrio = obj.features[i].attributes.PRENBARRIO,
                            Precmanz = obj.features[i].attributes.PRECMANZ,
                            Precpredio = obj.features[i].attributes.PRECPREDIO,
                            Preccons = obj.features[i].attributes.PRECCONS,
                            Precresto = obj.features[i].attributes.PRECRESTO,
                            Prechip = obj.features[i].attributes.PRECHIP,
                            Precedcata = obj.features[i].attributes.PRECEDCATA,
                            Prenupre = obj.features[i].attributes.PRENUPRE,
                            Pretprop = obj.features[i].attributes.PRETPROP,
                            Prefincorp = obj.features[i].attributes.PREFINCORP,
                            Preclase = obj.features[i].attributes.PRECLASE,
                            Predirecc = obj.features[i].attributes.PREDIRECC,
                            Premdirecc = obj.features[i].attributes.PREMDIRECC,
                            Pretdirecc = obj.features[i].attributes.PRETDIRECC,
                            Predsi = obj.features[i].attributes.PREDSI,
                            Preaterre = obj.features[i].attributes.PREATERRE,
                            Preaconst = obj.features[i].attributes.PREACONST,
                            Preczhf = obj.features[i].attributes.PRECZHF,
                            Precdestin = obj.features[i].attributes.PRECDESTIN,
                            Prevetustz = obj.features[i].attributes.PREVETUSTZ,
                            Prevforma = obj.features[i].attributes.PREVFORMA,
                            Prevactual = obj.features[i].attributes.PREVACTUAL,
                            Precuso = obj.features[i].attributes.PRECUSO,
                            Preauso = obj.features[i].attributes.PREAUSO,
                            Preusoph = obj.features[i].attributes.PREUSOPH,
                            Preusonph = obj.features[i].attributes.PREUSONPH,
                            Preuvivien = obj.features[i].attributes.PREUVIVIEN,
                            Preucalif = obj.features[i].attributes.PREUCALIF,
                            Prefcalif = obj.features[i].attributes.PREFCALIF,
                            Preearmaz = obj.features[i].attributes.PREEARMAZ,
                            Preemuros = obj.features[i].attributes.PREEMUROS,
                            Preecubier = obj.features[i].attributes.PREECUBIER,
                            Preecons = obj.features[i].attributes.PREECONS,
                            Preafachad = obj.features[i].attributes.PREAFACHAD,
                            Preacubier = obj.features[i].attributes.PREACUBIER,
                            Preapisos = obj.features[i].attributes.PREAPISOS,
                            Preacons = obj.features[i].attributes.PREACONS,
                            Prebtamano = obj.features[i].attributes.PREBTAMANO,
                            Prebenchap = obj.features[i].attributes.PREBENCHAP,
                            Prebmobili = obj.features[i].attributes.PREBMOBILI,
                            Prebcons = obj.features[i].attributes.PREBCONS,
                            Prectamano = obj.features[i].attributes.PRECTAMANO,
                            Precenchap = obj.features[i].attributes.PRECENCHAP,
                            Precmobili = obj.features[i].attributes.PRECMOBILI,
                            Precconse = obj.features[i].attributes.PRECCONSE,
                            Precindus = obj.features[i].attributes.PRECINDUS,
                            Preacercha = obj.features[i].attributes.PREACERCHA,
                            Preclcons = obj.features[i].attributes.PRECLCONS,
                            Barmanpre = obj.features[i].attributes.BARMANPRE,
                            Prepuntaje = obj.features[i].attributes.PREPUNTAJE,
                            Observations = null,
                            InsertionDate = System.DateTime.Now,
                            InsertUser = 1,
                            UpdateDate = null,
                            UpdateUser = null,
                            Active = true
                        };
                        db.TbllotePredios.Add(item);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("La insercion de Predio ha generado un error");
                }
            }
        }
    }
}
