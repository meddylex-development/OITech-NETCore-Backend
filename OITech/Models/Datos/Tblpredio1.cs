using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class Tblpredio1
    {
        public Guid UniIdpredio { get; set; }
        public Guid Uniunidad { get; set; }
        public double? FloareaConstruccion { get; set; }
        public string NvanumPredial { get; set; }
        public string NvacodDestino { get; set; }
        public double? FloareaTerreno { get; set; }
        public string? Nvaavaluo { get; set; }
        public string Nvadireccion { get; set; }
        public string NvacodDpto { get; set; }
        public string NvanumPredialAnterior { get; set; }
        public string NvacodMpio { get; set; }
        public string NvaObservacion { get; set; }
        public double FloFechaInsercion { get; set; }
        public Guid UniUsuarioInsercion { get; set; }
        public double? FloFechaModificacion { get; set; }
        public Guid? UniUsuarioModificacion { get; set; }
        public int IntActivo { get; set; }
    }
}
