using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models
{
    public partial class DetalleCalificacion
    {
        public string CodUso { get; set; }
        public string Uso { get; set; }
        public decimal? AreaUso { get; set; }
        public string UsoPh { get; set; }
        public string UsoNph { get; set; }
        public string UsoVivienda { get; set; }
        public string UnidadCalificada { get; set; }
        public long? FechaCalificacion { get; set; }
        public string CodArmazonEstructura { get; set; }
        public string MaterialArmazonEstructura { get; set; }
        public string CodMurosEstructura { get; set; }
        public string MaterialMurosEstructura { get; set; }
        public string CodCubiertaEstructura { get; set; }
        public string MaterialCubiertaEstructura { get; set; }
        public string CodConservacionEstructura { get; set; }
        public string EstadoConservacionEstructura { get; set; }
        public string CodFachadaAcabados { get; set; }
        public string MaterialFachadaAcabados { get; set; }
        public string CodCubiertaMurosAcabados { get; set; }
        public string MaterialCubiertaMurosAcabados { get; set; }
        public string CodPisosAcabados { get; set; }
        public string MaterialPisosAcabados { get; set; }
        public string CodConservacionAcabados { get; set; }
        public string EstadoConservacionAcabados { get; set; }
        public string CodTamanoBano { get; set; }
        public string TamanoBano { get; set; }
        public string CodEnchapeBano { get; set; }
        public string MaterialEnchapeBano { get; set; }
        public string CodMobiliarioBano { get; set; }
        public string MobiliarioBano { get; set; }
        public string CodConservacionBano { get; set; }
        public string EstadoConservacionBano { get; set; }
        public string CodTamanoCocina { get; set; }
        public string TamanoCocina { get; set; }
        public string CodEnchapeCocina { get; set; }
        public string MaterialEnchapeCocina { get; set; }
        public string CodMobiliarioCocina { get; set; }
        public string MobiliarioCocina { get; set; }
        public string CodConservacionCocina { get; set; }
        public string EstadoConservacionCocina { get; set; }
        public string CodComplementoIndustria { get; set; }
        public string MaterialComplementoIndustria { get; set; }
        public string AlturaCerchas { get; set; }
        public short? PuntajeCalificacion { get; set; }
        public string ClaseConstruccion { get; set; }
        public string Chip { get; set; }
    }
}
