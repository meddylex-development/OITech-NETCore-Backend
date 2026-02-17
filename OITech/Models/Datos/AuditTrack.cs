using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class AuditTrack
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdStatus { get; set; }
        public string Module { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
