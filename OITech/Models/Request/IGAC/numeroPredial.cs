using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Models.Request.IGAC
{

    public class RootnumeroPredial
    {
        public Response response { get; set; }
        public Gestor gestor { get; set; }
        public string message { get; set; }
        public bool status { get; set; }
    }

    public class Response
    {
        public Unidad unidad { get; set; }
        public Predio predio { get; set; }
        public Terreno terreno { get; set; }
    }

    public class Unidad
    {
        public string SHAPE { get; set; }
        public string TIPO { get; set; }
        public string CODIGO { get; set; }
        public string ID_UNIDAD_GEO { get; set; }
        public string NOMBRE_COMPLETO { get; set; }
        public string NOMBRE { get; set; }
    }

    public class Predio
    {
        public float areaConstruccion { get; set; }
        public string numPredial { get; set; }
        public string codDestino { get; set; }
        public float areaTerreno { get; set; }
        public string avaluo { get; set; }
        public string direccion { get; set; }
        public string codDpto { get; set; }
        public string numPredialAnterior { get; set; }
        public Construccione[] construcciones { get; set; }
        public string codMpio { get; set; }
    }

    public class Construccione
    {
        public float area { get; set; }
        public int uso { get; set; }
        public int puntaje { get; set; }
        public int numBanos { get; set; }
        public int numLocales { get; set; }
        public int numPisos { get; set; }
        public int numHabitaciones { get; set; }
    }

    public class Terreno
    {
        public Geometryproperties geometryProperties { get; set; }
        public Feature[] features { get; set; }
        public string globalIdFieldName { get; set; }
        public string objectIdFieldName { get; set; }
        public string Fuente { get; set; }
        public Spatialreference spatialReference { get; set; }
        public Field[] fields { get; set; }
        public Uniqueidfield uniqueIdField { get; set; }
        public string geometryType { get; set; }
    }

    public class Geometryproperties
    {
        public string shapeAreaFieldName { get; set; }
        public string shapeLengthFieldName { get; set; }
        public string units { get; set; }
    }

    public class Spatialreference
    {
        public int latestWkid { get; set; }
        public int wkid { get; set; }
    }

    public class Uniqueidfield
    {
        public bool isSystemMaintained { get; set; }
        public string name { get; set; }
    }

    public class Feature
    {
        public Centroid centroid { get; set; }
        public Attributes attributes { get; set; }
        public Geometry geometry { get; set; }
    }

    public class Centroid
    {
        public float x { get; set; }
        public float y { get; set; }
    }

    public class Attributes
    {
        public int OBJECTID { get; set; }
        public string CODIGO_DEPARTAMENTO { get; set; }
        public int NUMERO_SUBTERRANEOS { get; set; }
        public string CODIGO_ANTERIOR { get; set; }
        public string GLOBALID { get; set; }
        public string VEREDA_CODIGO { get; set; }
        public string CODIGO { get; set; }
        public float Shape__Length { get; set; }
        public float Shape__Area { get; set; }
        public string codigo_municipio { get; set; }
    }

    public class Geometry
    {
        public float[][][] rings { get; set; }
    }

    public class Field
    {
        public string sqlType { get; set; }
        public object defaultValue { get; set; }
        public object domain { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string type { get; set; }
        public int length { get; set; }
    }

    public class Gestor
    {
        public AttributesGestor attributes { get; set; }
    }

    public class AttributesGestor
    {
        public string gestor_contrato { get; set; }
        public string Shape__Length { get; set; }
        public long? fecha_contrato { get; set; }
        public long? inicio { get; set; }
        public string url_habilitacion { get; set; }
        public string mpnorma { get; set; }
        public string shape_leng { get; set; }
        public int mpcategor { get; set; }
        public string divipola { get; set; }
        public string gestor_catastral { get; set; }
        public int mpaltitud { get; set; }
        public string contacto { get; set; }
        public string responsable { get; set; }
        public string acto_admin { get; set; }
        public string municipio { get; set; }
        public string mparea { get; set; }
        public string mpcodigo { get; set; }
        public int objectid_1 { get; set; }
        public string ley617 { get; set; }
        public string mpnombre { get; set; }
        public string id_gc { get; set; }
        public string estado_actual { get; set; }
        public string Shape__Area { get; set; }
        public string url_servicio { get; set; }
        public string departamento { get; set; }
        public string depto { get; set; }
        public string restriccio { get; set; }
        public int objectid { get; set; }
    }

}






