using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectLemonade.Repository
{
    static class JsonFileHandler
    {
        public static Object ReadJsonObject(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var json = File.ReadAllText(filePath);
            Object characters = JsonSerializer.Deserialize<Object>(json, options);
            return characters;
        }

        public static void WriteJsonObject(Object obj, string fileName)
        {
            var jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
