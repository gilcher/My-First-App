using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace moy_sklad
{
    public static class HttpHelpers
    {
        static WebRequest webRequest;
        public static string GetData(string url, string userName, string password)
        {
            try
            {
                webRequest = WebRequest.Create(url);
                //webRequest.Proxy = HttpWebRequest.DefaultWebProxy;
                webRequest.Credentials = new NetworkCredential(userName, password);

                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

                Console.WriteLine(((HttpWebResponse)webResponse).StatusDescription);

                Stream responseStream = webResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                string s = streamReader.ReadToEnd();
                return s;
            }
            catch (Exception ex)
            {
                var err = ex.InnerException ?? ex;
                Console.WriteLine("Ошибка получения данных: {0}", err.Message);
                return String.Empty;
            }
        }
    }
}
