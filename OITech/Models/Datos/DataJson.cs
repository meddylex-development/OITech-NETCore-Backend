using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class DataJson
    {
        public int DataId { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Vereda { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
    }
}
