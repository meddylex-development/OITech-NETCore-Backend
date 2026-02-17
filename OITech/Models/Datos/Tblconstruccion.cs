using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class Tblconstruccion
    {
        public Guid UniIdconstruccion { get; set; }
        public Guid Unipredio { get; set; }
        public double? Floarea { get; set; }
        public int? Intuso { get; set; }
        public int? Intpuntaje { get; set; }
        public int? IntnumBanos { get; set; }
        public int? IntnumLocales { get; set; }
        public int? IntnumPisos { get; set; }
        public int? IntnumHabitaciones { get; set; }
        public string NvaObservacion { get; set; }
        public double FloFechaInsercion { get; set; }
        public Guid UniUsuarioInsercion { get; set; }
        public double? FloFechaModificacion { get; set; }
        public Guid? UniUsuarioModificacion { get; set; }
        public int IntActivo { get; set; }
    }
}
