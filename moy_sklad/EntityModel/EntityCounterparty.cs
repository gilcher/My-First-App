using moy_sklad.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moy_sklad
{
    class EntityCounterparty
    {
        public class Counterpartys
        {
            public Context context { get; set; }
            public Meta meta { get; set; }
            public Counterparty[] rows { get; set; }
        }  
    }
}
