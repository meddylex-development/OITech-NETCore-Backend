using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OITech.Models.Request
{
    public class catastroLotePredio
    {
        public class RootcatastroLotePredio
        {
            public string displayFieldName { get; set; }
            public Fieldaliases fieldAliases { get; set; }
            public Field[] fields { get; set; }
            public Feature[] features { get; set; }
        }

        public class Fieldaliases
        {
            public string OBJECTID { get; set; }
            public string PRECBARRIO { get; set; }
            public string PRENBARRIO { get; set; }
            public string PRECMANZ { get; set; }
            public string PRECPREDIO { get; set; }
            public string PRECCONS { get; set; }
            public string PRECRESTO { get; set; }
            public string PRECHIP { get; set; }
            public string PRECEDCATA { get; set; }
            public string PRENUPRE { get; set; }
            public string PRETPROP { get; set; }
            public string PREFINCORP { get; set; }
            public string PRECLASE { get; set; }
            public string PREDIRECC { get; set; }
            public string PREMDIRECC { get; set; }
            public string PRETDIRECC { get; set; }
            public string PREDSI { get; set; }
            public string PREATERRE { get; set; }
            public string PREACONST { get; set; }
            public string PRECZHF { get; set; }
            public string PRECDESTIN { get; set; }
            public string PREVETUSTZ { get; set; }
            public string PREVFORMA { get; set; }
            public string PREVACTUAL { get; set; }
            public string PRECUSO { get; set; }
            public string PREAUSO { get; set; }
            public string PREUSOPH { get; set; }
            public string PREUSONPH { get; set; }
            public string PREUVIVIEN { get; set; }
            public string PREUCALIF { get; set; }
            public string PREFCALIF { get; set; }
            public string PREEARMAZ { get; set; }
            public string PREEMUROS { get; set; }
            public string PREECUBIER { get; set; }
            public string PREECONS { get; set; }
            public string PREAFACHAD { get; set; }
            public string PREACUBIER { get; set; }
            public string PREAPISOS { get; set; }
            public string PREACONS { get; set; }
            public string PREBTAMANO { get; set; }
            public string PREBENCHAP { get; set; }
            public string PREBMOBILI { get; set; }
            public string PREBCONS { get; set; }
            public string PRECTAMANO { get; set; }
            public string PRECENCHAP { get; set; }
            public string PRECMOBILI { get; set; }
            public string PRECCONSE { get; set; }
            public string PRECINDUS { get; set; }
            public string PREACERCHA { get; set; }
            public string PRECLCONS { get; set; }
            public string BARMANPRE { get; set; }
            public string PREPUNTAJE { get; set; }
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
            public string PRECBARRIO { get; set; }
            public string PRENBARRIO { get; set; }
            public string PRECMANZ { get; set; }
            public string PRECPREDIO { get; set; }
            public string PRECCONS { get; set; }
            public string PRECRESTO { get; set; }
            public string PRECHIP { get; set; }
            public string PRECEDCATA { get; set; }
            public string PRENUPRE { get; set; }
            public short? PRETPROP { get; set; }
            public long? PREFINCORP { get; set; }
            public string PRECLASE { get; set; }
            public string PREDIRECC { get; set; }
            public string PREMDIRECC { get; set; }
            public string PRETDIRECC { get; set; }
            public string PREDSI { get; set; }
            public decimal? PREATERRE { get; set; }
            public decimal? PREACONST { get; set; }
            public string PRECZHF { get; set; }
            public string PRECDESTIN { get; set; }
            public short? PREVETUSTZ { get; set; }
            public short? PREVFORMA { get; set; }
            public short? PREVACTUAL { get; set; }
            public string PRECUSO { get; set; }
            public decimal? PREAUSO { get; set; }
            public string PREUSOPH { get; set; }
            public string PREUSONPH { get; set; }
            public string PREUVIVIEN { get; set; }
            public string PREUCALIF { get; set; }
            public long? PREFCALIF { get; set; }
            public string PREEARMAZ { get; set; }
            public string PREEMUROS { get; set; }
            public string PREECUBIER { get; set; }
            public string PREECONS { get; set; }
            public string PREAFACHAD { get; set; }
            public string PREACUBIER { get; set; }
            public string PREAPISOS { get; set; }
            public string PREACONS { get; set; }
            public string PREBTAMANO { get; set; }
            public string PREBENCHAP { get; set; }
            public string PREBMOBILI { get; set; }
            public string PREBCONS { get; set; }
            public string PRECTAMANO { get; set; }
            public string PRECENCHAP { get; set; }
            public string PRECMOBILI { get; set; }
            public string PRECCONSE { get; set; }
            public string PRECINDUS { get; set; }
            public string PREACERCHA { get; set; }
            public string PRECLCONS { get; set; }
            public string BARMANPRE { get; set; }
            public short? PREPUNTAJE { get; set; }
        }
    }
}
