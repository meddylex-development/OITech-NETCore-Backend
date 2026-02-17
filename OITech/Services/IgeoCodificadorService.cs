using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Services
{
    public interface IgeoCodificadorService
    {
        public void PostgeoCodificador(string dirinput);
        public string GetLastLotcodigo();
        public string GetLastMancodigo();
    }
}
