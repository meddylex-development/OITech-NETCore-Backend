using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Models.Request
{
    public class catastroLote
    {
        public class RootcatastroLote
        {
            public string displayFieldName { get; set; }
            public Fieldaliases fieldAliases { get; set; }
            public Field[] fields { get; set; }
            public Feature[] features { get; set; }
        }

        public class Fieldaliases
        {
            public string LOTCODIGO { get; set; }
            public string LOTDISPERS { get; set; }
            public string LOTILDISPE { get; set; }
            public string LOTUPREDIA { get; set; }
            public string LOTDISTRIT { get; set; }
            public string MANZCODIGO { get; set; }
            public string OBJECTID { get; set; }
            public string GLOBALID { get; set; }
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
            public string LOTCODIGO { get; set; }
            public string LOTDISPERS { get; set; }
            public string LOTILDISPE { get; set; }
            public int LOTUPREDIA { get; set; }
            public int LOTDISTRIT { get; set; }
            public string MANZCODIGO { get; set; }
            public int OBJECTID { get; set; }
            public Guid? GLOBALID { get; set; }
        }
    }
}
