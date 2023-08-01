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
        public static Object ReadJsonToObject(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            var json = reader.ReadToEnd();
            Object jsonObject = JsonConvert.DeserializeObject<Object>(json,
                new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return jsonObject;
        }

        public static List<Object> ReadJsonToList(string filePath) 
        {
            StreamReader reader = new StreamReader(filePath);
            var json = reader.ReadToEnd();
            List<Object> jsonList = JsonConvert.DeserializeObject<List<Object>>(json,
                new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return jsonList;
        }

        public static void WriteJsonFromObject(Object obj, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented,
                new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(fileName, jsonString);
        }

        public static void WriteJsonFromList(List<Object> list, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented,
                new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(fileName, jsonString);
        }

        public static void SaveCharacterToJson(Character character)
        {
            var jsonString = JsonConvert.SerializeObject(character, Formatting.Indented,
                new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText((character.CharacterName + ".json"), jsonString);
        }

        public static string GetCharacterFileName(string characterName) 
        {
            return (characterName + ".json");
        }
    }
}
