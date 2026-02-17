using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models
{
    public partial class Califiaccion
    {
        public decimal? AreaTerreno { get; set; }
        public decimal? AreaConstruccion { get; set; }
        public string CodDestinoEconomico { get; set; }
        public string DestinoEconomico { get; set; }
        public string Chip { get; set; }
    }
}
