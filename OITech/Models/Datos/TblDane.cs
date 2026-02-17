using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblDane
    {
        public int IIdDane { get; set; }
        public string CodDepartamento { get; set; }
        public string Departamento { get; set; }
        public string CodMunicipio { get; set; }
        public string Municipio { get; set; }
        public DateTime InsertionDate { get; set; }
        public int InsertUser { get; set; }
        public string UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool Active { get; set; }
    }
}
