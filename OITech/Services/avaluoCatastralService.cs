using Newtonsoft.Json;
using RestSharp;
using System;
using System.Linq;
using static OITech.Models.Request.avaluoCatastralIntegralPh;
using static OITech.Models.Request.avaluoCatastralTerrenoNph;
using OITech.Models.Datos;

namespace OITech.Services
{
    public class avaluoCatastralService : IavaluoCatastralService
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
            var obj = JsonConvert.DeserializeObject<RootavaluoCatastralTerrenoNph>(response.Content);
            var item = new TblavaluoCatastralTerrenoNph();
            int total = obj.features.Count();
            using (OITechContext db = new OITechContext())
            {
                try
                {
                    for (int i = 0; i < total; i++)
                    {
                        item = new TblavaluoCatastralTerrenoNph()
                        {
                            Objectid = obj.features[i].attributes.OBJECTID,
                            ManzanaId = obj.features[i].attributes.MANZANA_ID,
                            CpTerrArea = obj.features[i].attributes.CP_TERR_AREA,
                            GrupopTerrArea = obj.features[i].attributes.GRUPOP_TERR_AREA,
                            AvaluoCatMz = obj.features[i].attributes.AVALUO_CAT_MZ,
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
                        db.TblavaluoCatastralTerrenoNphs.Add(item);
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
            var obj = JsonConvert.DeserializeObject<RootavaluoCatastralIntegralPh>(response.Content);
            var item = new TblavaluoCatastralIntegralPh();
            int total = obj.features.Count();
            using (OITechContext db = new OITechContext())
            {
                try
                {
                    for (int i = 0; i < total; i++)
                    {
                        item = new TblavaluoCatastralIntegralPh()
                        {
                            Objectid = obj.features[i].attributes.OBJECTID,
                            ManzanaId = obj.features[i].attributes.MANZANA_ID,
                            CpTerrArea = obj.features[i].attributes.CP_TERR_AREA,
                            GrupopTerrArea = obj.features[i].attributes.GRUPOP_TERR_AREA,
                            AvaluoCatMz = obj.features[i].attributes.AVALUO_CAT_MZ,
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
                        db.TblavaluoCatastralIntegralPhs.Add(item);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("La insercion del terreno NPH ha generado un error");
                }
            }
        }
    }
}
