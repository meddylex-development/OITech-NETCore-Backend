using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Models.Request
{
    public class catastroLoteEstratoSocioeconomico
    {
        public class RootcatastroLoteEstratoSocioeconomico
        {
            public string displayFieldName { get; set; }
            public Fieldaliases fieldAliases { get; set; }
            public Field[] fields { get; set; }
            public Feature[] features { get; set; }
        }

        public class Fieldaliases
        {
            public string OBJECTID { get; set; }
            public string ESOCLOTE { get; set; }
            public string ESOCHIP { get; set; }
            public string ESOESTRATO { get; set; }
        }

        public class Field
        {
            public string name { get; set; }
            public string type { get; set; }
            public string alias { get; set; }
            public int length { get; set; }
        }

        public class Feature
        {
            public Attributes attributes { get; set; }
        }

        public class Attributes
        {
            public int OBJECTID { get; set; }
            public string ESOCLOTE { get; set; }
            public string ESOCHIP { get; set; }
            public int ESOESTRATO { get; set; }
        }
    }
}
