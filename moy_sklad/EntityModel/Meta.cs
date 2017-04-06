using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moy_sklad.EntityModel
{
    public class Meta
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
        public int size { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }
}
