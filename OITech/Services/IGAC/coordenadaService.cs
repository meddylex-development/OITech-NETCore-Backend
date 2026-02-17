using Newtonsoft.Json;
using OITech.Models.Request.IGAC;
using OITech.Models.Datos;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace OITech.Services.IGAC
{
    public class coordenadaService : IcoordenadaService
    {
        private readonly IConfiguration _configuration;

        public coordenadaService(
            IConfiguration configuration
            )
        {
            _configuration = configuration;
        }

        public void Postcoordenada(string x, string y)
        {
            var client = new RestClient("https://serviciosgeovisor.igac.gov.co:8080/Geovisor/catastral");
            var request = new RestRequest();
            request.AddParameter("cmd", "query_xy");
            var epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            request.AddParameter("t", epoch);
            x = x.Replace(',', '.');
            request.AddParameter("x", x);
            y = y.Replace(',', '.');
            request.AddParameter("y", y);
            RestResponse response = client.Execute(request);
            var obj = JsonConvert.DeserializeObject<RootnumeroPredial>(response.Content);
            Guid Id = Guid.NewGuid();
            
            if (obj.response == null)
            {
                if (obj.gestor == null)
                {
                    var Message = new TblGestor()
                    {
                        UniIdgestor = Id,
                        NvaObservacion = obj.message,
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
                            db.TblGestors.Add(Message);
                            db.SaveChanges();
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("Ocurrio un error en la inserción del gestor");
                    }
                }
                else
                {
                    var Gestor = new TblGestor()
                    {
                        UniIdgestor = Id,
                        NvagestorContrato = obj.gestor.attributes.gestor_contrato,
                        NvaShapeLength = obj.gestor.attributes.Shape__Length,
                        FlofechaContrato = obj.gestor.attributes.fecha_contrato,
                        Floinicio = obj.gestor.attributes.inicio,
                        NvaurlHabilitacion = obj.gestor.attributes.url_habilitacion,
                        Nvampnorma = obj.gestor.attributes.mpnorma,
                        NvashapeLeng = obj.gestor.attributes.shape_leng,
                        Intmpcategor = obj.gestor.attributes.mpcategor,
                        Nvadivipola = obj.gestor.attributes.divipola,
                        NvagestorCatastral = obj.gestor.attributes.gestor_catastral,
                        Intmpaltitud = obj.gestor.attributes.mpaltitud,
                        Nvacontacto = obj.gestor.attributes.contacto,
                        Nvaresponsable = obj.gestor.attributes.responsable,
                        NvaactoAdmin = obj.gestor.attributes.acto_admin,
                        Nvamunicipio = obj.gestor.attributes.municipio,
                        Nvamparea = obj.gestor.attributes.mparea,
                        Nvampcodigo = obj.gestor.attributes.mpcodigo,
                        Intobjectid1 = obj.gestor.attributes.objectid_1,
                        Nvaley617 = obj.gestor.attributes.ley617,
                        Nvampnombre = obj.gestor.attributes.mpnombre,
                        NvaidGc = obj.gestor.attributes.id_gc,
                        NvaestadoActual = obj.gestor.attributes.estado_actual,
                        NvaShapeArea = obj.gestor.attributes.Shape__Area,
                        NvaurlServicio = obj.gestor.attributes.url_servicio,
                        Nvadepartamento = obj.gestor.attributes.departamento,
                        Nvadepto = obj.gestor.attributes.depto,
                        Nvarestriccio = obj.gestor.attributes.restriccio,
                        Intobjectid = obj.gestor.attributes.objectid,
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
                            db.TblGestors.Add(Gestor);
                            db.SaveChanges();
                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("Ocurrio un error en la inserción del gestor");
                    }
                }
            }
            else
            {
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

                var terreno = new Tblterreno()
                {
                    Unipredio = Id,
                    Flocentroidx = obj.response.terreno.features[0].centroid.x,
                    Flocentroidy = obj.response.terreno.features[0].centroid.y,
                    IntObjectid = obj.response.terreno.features[0].attributes.OBJECTID,
                    IntNumeroSubterraneos = obj.response.terreno.features[0].attributes.NUMERO_SUBTERRANEOS,
                    NvaCodigoAnterior = obj.response.terreno.features[0].attributes.CODIGO_ANTERIOR,
                    NvaGlobalid = obj.response.terreno.features[0].attributes.GLOBALID,
                    NvaVeredaCodigo = obj.response.terreno.features[0].attributes.VEREDA_CODIGO,
                    NvaCodigo = obj.response.terreno.features[0].attributes.CODIGO,
                    FloShapeLength = obj.response.terreno.features[0].attributes.Shape__Length,
                    FloShapeArea = obj.response.terreno.features[0].attributes.Shape__Area,
                    NvacodigoMunicipio = obj.response.terreno.features[0].attributes.codigo_municipio,
                    NvaglobalIdFieldName = obj.response.terreno.globalIdFieldName,
                    NvaobjectIdFieldName = obj.response.terreno.objectIdFieldName,
                    NvaFuente = obj.response.terreno.Fuente,
                    IntlatestWkid = obj.response.terreno.spatialReference.latestWkid,
                    Intwkid = obj.response.terreno.spatialReference.wkid,
                    NvageometryType = obj.response.terreno.geometryType,
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
                        db.Tblterrenos.Add(terreno);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Ocurrio un error en la inserción del terreno");
                }
            }
        }

        public void GetCoordenadas()
        {
            string SProcedure = @"Admin.SPJSON";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("OITechContext");
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                SqlDataReader myReader;
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(SProcedure, myCon))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            if (table.Rows.Count > 0)
            {
                foreach (DataRow ren in table.Rows)
                {
                    Postcoordenada(ren[1].ToString(), ren[2].ToString());
                }
            }
        }
    }
}
