using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace moy_sklad
{
    public class DEX_BaseResponse
    {
        [DataMemberAttribute]
        public DEX_DTErrorResponse ErrorResponse;

        public DEX_BaseResponse()
        {
            ErrorResponse = new DEX_DTErrorResponse();
        }

    }
}
