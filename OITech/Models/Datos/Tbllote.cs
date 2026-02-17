using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class Tbllote
    {
        public int IIdlote { get; set; }
        public string Lotcodigo { get; set; }
        public string Lotdispers { get; set; }
        public string Lotildispe { get; set; }
        public int? Lotupredia { get; set; }
        public int? Lotdistrit { get; set; }
        public string Manzcodigo { get; set; }
        public int? Objectid { get; set; }
        public string Shape { get; set; }
        public Guid? Globalid { get; set; }
        public string Observations { get; set; }
        public DateTime InsertionDate { get; set; }
        public int InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool Active { get; set; }
    }
}
