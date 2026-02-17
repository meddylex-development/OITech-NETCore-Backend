using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class Tblunidad
    {
        public Guid UniIdunidad { get; set; }
        public string NvaTipo { get; set; }
        public string NvaCodigo { get; set; }
        public string NvaIdUnidadGeo { get; set; }
        public string NvaNombreCompleto { get; set; }
        public string NvaNombre { get; set; }
        public string NvaObservacion { get; set; }
        public double FloFechaInsercion { get; set; }
        public Guid UniUsuarioInsercion { get; set; }
        public double? FloFechaModificacion { get; set; }
        public Guid? UniUsuarioModificacion { get; set; }
        public int IntActivo { get; set; }
        public string NvaCedulacatastral { get; set; }
    }
}
