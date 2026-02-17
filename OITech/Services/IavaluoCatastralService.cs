using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Services
{
    public interface IavaluoCatastralService
    {
        public void GetTerrenoNPH(string MANZANA_ID);
        public void GetIntegralPH(string MANZANA_ID);
    }
}
