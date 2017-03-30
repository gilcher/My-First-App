using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moy_sklad
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            string password = "";

            string urlString = @"https://online.moysklad.ru/api/remap/1.1/entity/demand/metadata";
            string urlContragent = @"https://online.moysklad.ru/api/remap/1.1/entity/counterparty";
            var rslJson = HttpHelpers.GetData(urlContragent, userName, password);

            Entity.Rootobject json = JsonConvert.DeserializeObject<Entity.Rootobject>(rslJson);
            List<Entity.Counterparty> CounterpartyList = json.rows.ToList();
            Console.ReadKey();
        }
    }
}
