using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SunClouds.ViewModel.Helpers
{
    internal class APIHelper
    {
        /// <summary>
        /// Ссылка на WEB API (обязательно)
        /// </summary>
        private static string url = "http://api.openweathermap.org/data/2.5/";
        private static string apiKey = "d45b132e82951a41b303024d04324813";


        /// <summary>
        /// Запрос на получение всех данных из API
        /// </summary>
        /// <returns>Json из API</returns>
        public static string Get(string city, string units = "standart")
        {
            string data = $"weather?q={city}&units={units}&appid={apiKey}";
            return new HttpClient().GetAsync(url + data).Result.Content.ReadAsStringAsync().Result;
        }

        public static string Put(string json, string city, string units = "standart")
        {
            string data = $"weather?q={city}&units={units}&appid={apiKey}";
            return new HttpClient().PutAsync(url + data, new StringContent(json)).Result.Content.ReadAsStringAsync().Result;
        }
        /// <summary>
        /// Запрос на добавление данных в API
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Json из API</returns>
        public static string Post(string json)
        {
            return new HttpClient().PostAsync(url, new StringContent(json)).Result.Content.ReadAsStringAsync().Result;
        }
        /// <summary>
        /// Запрос на удаление данных из API
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Json из API</returns>
        public static string Delete(int id)
        {
            return new HttpClient().DeleteAsync(url + id).Result.Content.ReadAsStringAsync().Result;
        }

    }
}
