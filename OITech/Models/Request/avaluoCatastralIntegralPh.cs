using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Models.Request
{
    public class avaluoCatastralIntegralPh
    {

        public class RootavaluoCatastralIntegralPh
        {
            public string displayFieldName { get; set; }
            public Fieldaliases fieldAliases { get; set; }
            public Field[] fields { get; set; }
            public Feature[] features { get; set; }
        }

        public class Fieldaliases
        {
            public string OBJECTID { get; set; }
            public string MANZANA_ID { get; set; }
            public string CP_TERR_AREA { get; set; }
            public string GRUPOP_TERR_AREA { get; set; }
            public string AVALUO_CAT_MZ { get; set; }
            public string OBSERVACION { get; set; }
            public string GLOBALID { get; set; }
            public string SHAPEAREA { get; set; }
            public string SHAPELEN { get; set; }
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
            public string MANZANA_ID { get; set; }
            public string CP_TERR_AREA { get; set; }
            public string GRUPOP_TERR_AREA { get; set; }
            public float AVALUO_CAT_MZ { get; set; }
            public string OBSERVACION { get; set; }
            public string GLOBALID { get; set; }
            public float SHAPEAREA { get; set; }
            public float SHAPELEN { get; set; }
        }
    }
}
