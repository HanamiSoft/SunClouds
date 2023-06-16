namespace SunClouds
{

    public class CurrentWeather
    {
        public Coord coord { get; set; } // Класс координат города
        public Weather[] weather { get; set; } // Массив размером в один элемент
        public string _base { get; set; } // Станции какие-то, idk
        public Main main { get; set; } // Основные данные по погоде (конкретные числа)
        public int visibility { get; set; } // Видимость
        public Wind wind { get; set; } // Всё о ветерке
        public Clouds clouds { get; set; } // Всё об облачках
        public int dt { get; set; } // Timestamp времени, на которое дана погода
        public Sys sys { get; set; } // Метаданные
        public int timezone { get; set; } //  Временная зона?
        public int id { get; set; } // Пусть будет, idk
        public string name { get; set; } // Это - твоя Коноха
        public int cod { get; set; } // Код от API
    }

    public class Coord
    {
        public float lon { get; set; } // Географическая долгота
        public float lat { get; set; } // Географическая широта
    }

    public class Main
    {
        public float temp { get; set; } // Температура в градусах
        public float feels_like { get; set; } // Ощущение в градусах температуры
        public float temp_min { get; set; } // Минимальная температура
        public float temp_max { get; set; } // Максимальная температура
        public int pressure { get; set; } // Давление
        public int humidity { get; set; } // Влажность
        public int sea_level { get; set; } // Уровень моря
        public int grnd_level { get; set; } // Уровень земли
        public float temp_kf { get; set; }
    }

    public class Wind
    {
        public float speed { get; set; } // Скорость в м/с
        public int deg { get; set; } // idk
        public float gust { get; set; } // idk
    }

    public class Clouds
    {
        public int all { get; set; } // Количество облачков на небе?
    }

    public class Sys
    {
        public int type { get; set; } // idk
        public int id { get; set; } // idk
        public string country { get; set; } // Страна
        public int sunrise { get; set; } // Timestamp рассвета
        public int sunset { get; set; } // Timestamp заката
    }

    public class Weather
    {
        public int id { get; set; } // idk
        public string main { get; set; } // Погода, к примеру: "облачно"
        public string description { get; set; } // Описание погоды, к примеру: "рассеянные облака"
        public string icon { get; set; } // idk, к примеру: "03d"
    }

}
