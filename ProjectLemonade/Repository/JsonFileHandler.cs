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
        public static object ReadJsonToObject(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            var json = reader.ReadToEnd();
            object jsonObject = JsonConvert.DeserializeObject<object>(json,
                new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return jsonObject;
        }

        public static void WriteJsonFromObject(object obj, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented,
                new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(fileName, jsonString);
        }

        public static void SaveCharacterToJson(Character character)
        {
            WriteJsonFromObject(character, character.CharacterName + ".json");
        }

        public static string GetCharacterFileName(string characterName) 
        {
            return (characterName + ".json");
        }

        public static List<T> GetListFromFile<T>(string filename)
        {
            List<T> list = (List<T>)JsonFileHandler.ReadJsonToObject(@filename + ".json");
            return list;
        }
    }
}
