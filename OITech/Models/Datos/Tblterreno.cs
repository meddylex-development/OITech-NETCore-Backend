using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class Tblterreno
    {
        public Guid UniIdterreno { get; set; }
        public Guid Unipredio { get; set; }
        public double? Flocentroidx { get; set; }
        public double? Flocentroidy { get; set; }
        public int? IntObjectid { get; set; }
        public int? IntNumeroSubterraneos { get; set; }
        public string NvaCodigoAnterior { get; set; }
        public string NvaGlobalid { get; set; }
        public string NvaVeredaCodigo { get; set; }
        public string NvaCodigo { get; set; }
        public double? FloShapeLength { get; set; }
        public double? FloShapeArea { get; set; }
        public string NvacodigoMunicipio { get; set; }
        public string NvaglobalIdFieldName { get; set; }
        public string NvaobjectIdFieldName { get; set; }
        public string NvaFuente { get; set; }
        public int? IntlatestWkid { get; set; }
        public int? Intwkid { get; set; }
        public string NvageometryType { get; set; }
        public string NvaObservacion { get; set; }
        public double FloFechaInsercion { get; set; }
        public Guid UniUsuarioInsercion { get; set; }
        public double? FloFechaModificacion { get; set; }
        public Guid? UniUsuarioModificacion { get; set; }
        public int IntActivo { get; set; }
    }
}
