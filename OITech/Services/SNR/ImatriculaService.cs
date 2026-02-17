using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Services.SNR
{
    public interface ImatriculaService
    {
        public string matriculaInmobiliara(string Oficina, string Numero);
        public string compraMatriculaInmobiliara(string Oficina, string Numero, string user, string pass);
        public string buscarMatriculaInmobiliaraComprada(string Numero, string user, string pass);
        public string consultarSaldo(string user, string pass);
    }
}
