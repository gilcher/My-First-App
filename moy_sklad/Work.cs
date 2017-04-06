using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moy_sklad
{
    /// <summary>
    /// Вся работа тут
    /// </summary>
    public static class Work
    {
        #region DEX_CheckConnect
        public static DEX_BaseResponse DEX_CheckConnect(string Session_Ident)
        {
            DEX_BaseResponse result = new DEX_BaseResponse();

            //Подключиться к AL, получить параметры подключения к облачному сервису Cloud-ERP

            //Подключиться к сервису Cloud-ERP, авторизоваться

            //Вернуть статус обработки
            return result;
        }
        #endregion

        #region DEX_Import_Request
        public static DEX_BaseResponse DEX_Import_Request(string Session_Ident, DateTime Date_Data, object Request_Id)
        {
            DEX_BaseResponse result = new DEX_BaseResponse();

            //Подключиться к AL, получить параметры подключения к облачному сервису Cloud-ERP

            //Подключиться к сервису Cloud-ERP, авторизоваться

            //Загрузить заявки с Cloud-ERP за указанную дату

            //Преобразовать структуры полученных данных из Cloud-ERP в структуры AL

            //Передать заявки в AL

            //Вернуть статус обработки
            return result;
        }
        #endregion

        #region DEX_Export_Response
        public static DEX_BaseResponse DEX_Export_Response(string Session_Ident, DateTime Date_Data, object Route_Id)
        {
            DEX_BaseResponse result = new DEX_BaseResponse();

            //Подключиться к AL, получить параметры подключения к облачному сервису Cloud-ERP

            //Подключиться к сервису Cloud-ERP, авторизоваться

            //Получить готовые маршруты с AL за указанную дату 

            //Преобразовать структуры полученных данных из AL в Cloud-ERP

            //Передать готовые маршруты на сервис Cloud-ERP

            //Вернуть статус обработки
            return result;
        }
        #endregion


        #region Служебные методы
        public static HttpRequest_Light StreamToHttpRequest(Stream data)
        {
            HttpRequest_Light req = new HttpRequest_Light();
            string reqData = null;

            // Не сжатый контент
            StreamReader reader = new StreamReader(data);
            reqData = reader.ReadToEnd();

            return req;
        }


        #endregion
    }

}
