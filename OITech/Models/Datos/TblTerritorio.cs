using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblTerritorio
    {
        public int Objectid { get; set; }
        public string CodDpto { get; set; }
        public string NomDep { get; set; }
        public string Dptompio { get; set; }
        public string NombMpio { get; set; }
        public string CodigoVer { get; set; }
        public string NombreVer { get; set; }
        public string Vigencia { get; set; }
        public string Fuente { get; set; }
        public string Descripcio { get; set; }
        public string Seudonimos { get; set; }
        public double AreaHa { get; set; }
        public double ShapeStarea { get; set; }
        public double ShapeStlength { get; set; }
    }
}
