using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblloteEstratoSocioeconomico
    {
        public int IIdloteEstratoSocioeconomico { get; set; }
        public int? Objectid { get; set; }
        public string Esoclote { get; set; }
        public string Esochip { get; set; }
        public int? Esoestrato { get; set; }
        public string Observations { get; set; }
        public DateTime InsertionDate { get; set; }
        public int InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool Active { get; set; }
    }
}
