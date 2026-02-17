using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Models.Request
{

    public class RootgeoCodificador
    {
        public Response response { get; set; }
        public bool status { get; set; }
    }

    public class Response
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
        public int Exito { get; internal set; }
        public string Mensaje { get; internal set; }
    }

    public class Data
    {
        public string estado { get; set; }
        public float yinput { get; set; }
        public string lotcodigo { get; set; }
        public string latitude { get; set; }
        public string diraprox { get; set; }
        public string mancodigo { get; set; }
        public string cpocodigo { get; set; }
        public float xinput { get; set; }
        public string codloc { get; set; }
        public string dirtrad { get; set; }
        public string nomupz { get; set; }
        public string localidad { get; set; }
        public string dirinput { get; set; }
        public string codupz { get; set; }
        public string nomseccat { get; set; }
        public string tipo_direccion { get; set; }
        public string codseccat { get; set; }
        public string longitude { get; set; }
    }
}
