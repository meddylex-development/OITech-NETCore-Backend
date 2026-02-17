using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Services
{
    public interface IavaluoComercialService
    {
        public void GetTerrenoNPH(string MANZANA_ID);
        public void GetIntegralPH(string MANZANA_ID);
    }
}
