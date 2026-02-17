using Newtonsoft.Json;
using RestSharp;
using System;
using System.Linq;
using static OITech.Models.Request.avaluoComercialIntegralPh;
using static OITech.Models.Request.avaluoComercialTerrenoNph;
using OITech.Models.Datos;

namespace OITech.Services
{
    public class avaluoComercialService : IavaluoComercialService
    {
        //Servicio Get Terreno NPH
        public void GetTerrenoNPH(string MANZANA_ID)
        {
            var client = new RestClient("https://serviciosgis.catastrobogota.gov.co/arcgis/rest/services/catastro/avaluoscomerciales/MapServer/0/query");
            var request = new RestRequest();
            request.AddParameter("where", "MANZANA_ID LIKE '" + MANZANA_ID + "'");
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
            var obj = JsonConvert.DeserializeObject<RootavaluoComercialTerrenoNph>(response.Content);
            var item = new TblavaluoComercialTerrenoNph();
            int total = obj.features.Count();
            using (OITechContext db = new OITechContext())
            {
                try
                {
                    for (int i = 0; i < total; i++)
                    {
                        item = new TblavaluoComercialTerrenoNph()
                        {
                            Objectid = obj.features[i].attributes.OBJECTID,
                            ManzanaId = obj.features[i].attributes.MANZANA_ID,
                            CpTerrArea = obj.features[i].attributes.CP_TERR_AREA,
                            GrupopTerrArea = obj.features[i].attributes.GRUPOP_TERR_AREA,
                            AvaluoComMz = obj.features[i].attributes.AVALUO_COM_MZ,
                            Observacion = obj.features[i].attributes.OBSERVACION,
                            Shape = "Envelope",
                            Globalid = obj.features[i].attributes.GLOBALID,
                            Area = obj.features[i].attributes.SHAPEAREA,
                            Len = obj.features[i].attributes.SHAPELEN,
                            Observations = null,
                            InsertionDate = System.DateTime.Now,
                            InsertUser = 1,
                            UpdateDate = null,
                            UpdateUser = null,
                            Active = true
                        };
                        db.TblavaluoComercialTerrenoNphs.Add(item);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("La insercion del terreno NPH ha generado un error");
                }
            }
        }

        //Servicio Get Integral PH
        public void GetIntegralPH(string MANZANA_ID)
        {
            var client = new RestClient("https://serviciosgis.catastrobogota.gov.co/arcgis/rest/services/catastro/avaluoscomerciales/MapServer/1/query");
            var request = new RestRequest();
            request.AddParameter("where", "MANZANA_ID LIKE '" + MANZANA_ID + "'");
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
            var obj = JsonConvert.DeserializeObject<RootavaluoComercialIntegralPh>(response.Content);
            var item = new TblavaluoComercialIntegralPh();
            int total = obj.features.Count();
            using (OITechContext db = new OITechContext())
            {
                try
                {
                    for (int i = 0; i < total; i++)
                    {
                        item = new TblavaluoComercialIntegralPh()
                        {
                            Objectid = obj.features[i].attributes.OBJECTID,
                            ManzanaId = obj.features[i].attributes.MANZANA_ID,
                            CpTerrArea = obj.features[i].attributes.CP_TERR_AREA,
                            GrupopTerrArea = obj.features[i].attributes.GRUPOP_TERR_AREA,
                            AvaluoComMz = obj.features[i].attributes.AVALUO_COM_MZ,
                            Observacion = obj.features[i].attributes.OBSERVACION,
                            Shape = "Envelope",
                            Globalid = obj.features[i].attributes.GLOBALID,
                            Area = obj.features[i].attributes.SHAPEAREA,
                            Len = obj.features[i].attributes.SHAPELEN,
                            Observations = null,
                            InsertionDate = System.DateTime.Now,
                            InsertUser = 1,
                            UpdateDate = null,
                            UpdateUser = null,
                            Active = true
                        };
                        db.TblavaluoComercialIntegralPhs.Add(item);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("La insercion del Integral PH ha generado un error");
                }
            }
        }
    }
}
