using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblTerritorioCoordenada
    {
        public int CoordenadasId { get; set; }
        public int Objectid { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
        public int Polygon { get; set; }
    }
}
