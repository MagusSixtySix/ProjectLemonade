using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ProjectLemonade.Repository
{
    static class JsonFileHandler
    {
        public static Object ReadJsonObject(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            var json = reader.ReadToEnd();
            Object characters = JsonConvert.DeserializeObject<Object>(json, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return characters;
        }

        public static void WriteJsonObject(Object obj, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(fileName, jsonString);
        }
    }
}
