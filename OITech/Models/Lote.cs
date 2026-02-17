using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models
{
    public partial class Lote
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string CodLocalidad { get; set; }
        public string Localidad { get; set; }
        public string CodUpz { get; set; }
        public string UnidadPlaneacionZonal { get; set; }
        public string CodBarrio { get; set; }
        public string Barrio { get; set; }
        public string CodManzana { get; set; }
        public string CodLote { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Disperso { get; set; }
        public string CodDisperso { get; set; }
        public int? UnidadPredial { get; set; }
        public string Distrito { get; set; }
    }
}
