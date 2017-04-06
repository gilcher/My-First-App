using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace moy_sklad
{
    public class DEX_DTErrorResponse
    {
        public enum ErrorStatus { OK = 0, ERR = 1, ERR_SESSION_CLOSE = 2, ERR_KNOWN = 3, INFO = 4, WARNING = 5, VIOLATION_TARIFF = 6 };

        [DataMemberAttribute]
        public ErrorStatus error;
        [DataMemberAttribute]
        public string msg = "";

        public DEX_DTErrorResponse() { error = ErrorStatus.OK; }

        public void SetError(Exception ex)
        {
            error = ErrorStatus.ERR;
            msg = ex.Message;
        }
    }
}
