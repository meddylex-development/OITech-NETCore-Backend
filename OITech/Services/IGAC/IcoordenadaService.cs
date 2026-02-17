using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Services.IGAC
{
    public interface IcoordenadaService
    {
        public void Postcoordenada(string x, string y);
        public void GetCoordenadas();
    }
}
