using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models
{
    public partial class DetallePredio
    {
        public string Direccion { get; set; }
        public string MarcaDireccion { get; set; }
        public string TipoDireccion { get; set; }
        public string DireccionSecundariaIncluye { get; set; }
        public int? Estrato { get; set; }
        public short? CodTipoPredio { get; set; }
        public string TipoPredio { get; set; }
        public string ClasePredio { get; set; }
        public short? Vetustez { get; set; }
        public short? VigenciaFormacion { get; set; }
        public long? FechaIncorporacion { get; set; }
        public short? VigenciaActualizacion { get; set; }
        public string Chip { get; set; }
    }
}
