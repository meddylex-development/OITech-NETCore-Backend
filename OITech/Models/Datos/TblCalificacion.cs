using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class TblCalificacion
    {
        public int IIdCalificacion { get; set; }
        public string CodCalificacion { get; set; }
        public string Construccion { get; set; }
        public string Descripcion { get; set; }
        public string Material { get; set; }
        public int? Residencial { get; set; }
        public int? Comercial { get; set; }
        public int? Industrial { get; set; }
        public DateTime InsertionDate { get; set; }
        public int InsertUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUser { get; set; }
        public bool Active { get; set; }
    }
}
