using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace moy_sklad
{
    public class HttpRequest_Light
    {
        public string Url_OriginalString;
        public NameValueCollection Params;
        public HttpRequest_Light() { Params = new NameValueCollection(); }
    }
}
