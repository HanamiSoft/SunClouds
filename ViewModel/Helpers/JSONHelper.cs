using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Documents;

namespace SunClouds.ViewModel.Helpers
{
    /// <summary>
    /// Класс-помощник для десериализации и сериализации коллекции.<br/>
    /// Сохранение json по умолчанию на рабочий стол.<br/>
    /// В пределах программы работает только с одним файлом.
    /// </summary>
    internal class JSONHelper
    {
        //Название файла (как душе угодно)
        static string variable = "SunClouds.json";
        // Путь для сохранения (как душе угодно). По умолчанию - рабочий стол
        static string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\{variable}";

        public static void Serialization<T>(List<T> serializableList)
        {
            string json = JsonConvert.SerializeObject(serializableList);
            File.WriteAllText(path, json);
        }

        public static List<T> Deserialization<T>(List<T> list)
        {
            if (!File.Exists(path))
                Serialization(list);
            string json = File.ReadAllText(path);
            List<T> serializedList = JsonConvert.DeserializeObject<List<T>>(json);
            return serializedList;
        }
    }
}
