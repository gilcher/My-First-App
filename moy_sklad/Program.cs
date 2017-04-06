using moy_sklad.EntityModel;
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
            ERP_ConnectionSettings connStng = new ERP_ConnectionSettings()
              { userName = "admin@ant-log",
                password = "9f838a123a",
                url_APICloudeERP = "https://online.moysklad.ru/api/remap/1.1/entity/counterparty/4b1902de-1632-11e7-7a69-93a7004182ac" };

            string userName = "admin@ant-log";
            string password = "9f838a123a";
            string errConnect = String.Empty;

            if (DEX_CheckConnect(connStng, ref errConnect))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Подключение произведено успешно!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Подключение не произведено: {0}", errConnect);
                Console.ForegroundColor = ConsoleColor.White;
            }            

            string urlString = @"https://online.moysklad.ru/api/remap/1.1/entity/demand/metadata";
            string urlContragents = @"https://online.moysklad.ru/api/remap/1.1/entity/counterparty?offset=0&limit=109";
            string urlContragent = @"https://online.moysklad.ru/api/remap/1.1/entity/counterparty/4b1902de-1632-11e7-7a69-93a7004182ac";
            string urlcustomerorder = @"https://online.moysklad.ru/api/remap/1.1/entity/customerorder";
            var rslJson = HttpHelpers.GetData(urlcustomerorder, userName, password);

            EntityCounterparty.Counterpartys json = JsonConvert.DeserializeObject<EntityCounterparty.Counterpartys>(rslJson);
            List<Counterparty> CounterpartyList = json.rows.ToList();
            Console.ReadKey();
        }

        /// <summary>
        /// Проверка соединения. 
        /// Проверяет, что Cloud-ERP доступен и параметры авторизации верны.
        /// </summary>
        /// <param name="connSettings">параметры авторизации</param>
        /// <returns></returns>
        private static bool DEX_CheckConnect(ERP_ConnectionSettings connSettings, ref string errConnect)
        {
            if (connSettings == null) return false;

            if (HttpHelpers.CheckConnection(connSettings.url_APICloudeERP, connSettings.userName, connSettings.password, ref errConnect) == "OK")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Импорт заявок.
        /// Передает заявки из Cloud-ERP в AL.
        /// </summary>
        /// <returns></returns>
        private static bool DEX_Import_Request()
        {
            return false;
        }

        /// <summary>
        /// Экспорт маршрутов. 
        /// Передает маршруты из AL в Cloud-ERP.
        /// </summary>
        /// <returns></returns>
        private static bool DEX_Export_Response()
        {
            return false;
        }
    }
}
