using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblBarrio
    {
        public int Objectid { get; set; }
        public string IdBarrio { get; set; }
        public string CodigoBarrio { get; set; }
        public string Zona { get; set; }
        public string Sector { get; set; }
        public string Barrio { get; set; }
        public string NombreBarrio { get; set; }
        public string ZonaBarrio { get; set; }
        public string Comuna { get; set; }
        public string NombreComuna { get; set; }
        public string Dptompio { get; set; }
    }
}
