using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblGeocodificador
    {
        public int IIdGeocodificador { get; set; }
        public string Estado { get; set; }
        public string Lotcodigo { get; set; }
        public string Latitude { get; set; }
        public string Diraprox { get; set; }
        public string Mancodigo { get; set; }
        public string Cpocodigo { get; set; }
        public string Codloc { get; set; }
        public string Dirtrad { get; set; }
        public string Nomupz { get; set; }
        public string Localidad { get; set; }
        public string Codupz { get; set; }
        public string Nomseccat { get; set; }
        public string TipoDireccion { get; set; }
        public string Codseccat { get; set; }
        public string Longitude { get; set; }
        public DateTime InsertionDate { get; set; }
        public int InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool Active { get; set; }
        public string Dirinput { get; set; }
        public double? Xinput { get; set; }
        public double? Yinput { get; set; }
    }
}
