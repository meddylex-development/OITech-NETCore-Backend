using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblavaluoCatastralTerrenoNph
    {
        public int IIdavaluoCatastralTerrenoNph { get; set; }
        public int? Objectid { get; set; }
        public string ManzanaId { get; set; }
        public string CpTerrArea { get; set; }
        public string GrupopTerrArea { get; set; }
        public double? AvaluoCatMz { get; set; }
        public string Observacion { get; set; }
        public string Shape { get; set; }
        public string Globalid { get; set; }
        public double? Area { get; set; }
        public double? Len { get; set; }
        public string Observations { get; set; }
        public DateTime InsertionDate { get; set; }
        public int InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool Active { get; set; }
    }
}
