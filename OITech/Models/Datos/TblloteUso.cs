using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblloteUso
    {
        public int IIdloteUso { get; set; }
        public int? Objectid { get; set; }
        public string Usoclote { get; set; }
        public string Usotuso { get; set; }
        public decimal? Usoarea { get; set; }
        public string Observations { get; set; }
        public DateTime InsertionDate { get; set; }
        public int InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool Active { get; set; }
    }
}
