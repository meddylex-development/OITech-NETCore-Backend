using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblMultivalore
    {
        public int IIdMultivalores { get; set; }
        public int? CodAgrupador { get; set; }
        public string NombreAgrupador { get; set; }
        public int? CodItem { get; set; }
        public string CodItemstring { get; set; }
        public string NombreItem { get; set; }
        public DateTime InsertionDate { get; set; }
        public int InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool Active { get; set; }
        public string Minimo { get; set; }
        public string Maximo { get; set; }
    }
}
