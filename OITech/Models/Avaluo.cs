using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models
{
    public partial class Avaluo
    {
        public string ClasePredio { get; set; }
        public string GrupoEconomico { get; set; }
        public double? AvaluoCatastralIntegral { get; set; }
        public double? AvaluoCatastralTerreno { get; set; }
        public double? AvaluoComercialIntegral { get; set; }
        public double? AvaluoComercialTerreno { get; set; }
        public string Observacion { get; set; }
        public string ManzanaId { get; set; }
    }
}
