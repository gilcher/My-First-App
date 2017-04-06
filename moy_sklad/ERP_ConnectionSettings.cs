using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moy_sklad
{
    class ERP_ConnectionSettings
    {
        /// <summary>
        /// Тип облачного сервиса
        /// </summary>
        public string type_CloudeERP { get; set; }
        /// <summary>
        /// Адрес API облачного сервиса
        /// </summary>
        public string url_APICloudeERP { get; set; }
        /// <summary>
        /// Имя пользователя который подключается
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// Версия API облачного сервиса
        /// </summary>
        public string version_APICloudeREP { get; set; }
        /// <summary>
        /// Дополнительные параметры
        /// </summary>
        Dictionary<dynamic, dynamic> ext_Parametr;


    }
}
