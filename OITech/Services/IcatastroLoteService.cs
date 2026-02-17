using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Services
{
    public interface IcatastroLoteService
    {
        public void GetLote(string LOTCODIGO);
        public void GetEstratoSocioeconomico(string ESOCLOTE);
        public void GetUso(string USOCLOTE);
        public void GetPredio(string BARMANPRE);
    }
}
