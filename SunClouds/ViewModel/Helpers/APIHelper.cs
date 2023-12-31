﻿using SunClouds.Properties;
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
        /// Запрос на получение текущей погоды города из API.
        /// Вторым параметрам передаётся тип градусов температуры: <br/> standard = kelvin <br/> metric = celsius <br/> imperial = fahrenheit
        /// </summary>
        /// <returns>Json из API</returns>
        public static string GetNow()
        {
            string units = Settings.Default.Celsius ? "metric" : "imperial";
            string data = $"weather?q={Settings.Default.City}&units={units}&appid={apiKey}";
            return new HttpClient().GetAsync(url + data).Result.Content.ReadAsStringAsync().Result;
        }
        /// <summary>
        /// Запрос на получение погоды города на каждые 3 часа вперёд из API
        /// Вторым параметрам передаётся тип градусов температуры: <br/> standard = kelvin <br/> metric = celsius <br/> imperial = fahrenheit
        /// </summary>
        /// <returns></returns>
        public static string GetThreeHours()
        {
            string units = Settings.Default.Celsius ? "metric" : "imperial";
            string data = $"forecast?q={Settings.Default.City}&units={units}&appid={apiKey}";
            return new HttpClient().GetAsync(url + data).Result.Content.ReadAsStringAsync().Result;
        }

    }
}
