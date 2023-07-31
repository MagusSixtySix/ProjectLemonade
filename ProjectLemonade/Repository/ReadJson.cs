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
    internal class ReadJson : IRepository
    {
        public Object ReadJsonObject(string filePath)
        {
            var json = File.ReadAllText(filePath);
            Object characters = JsonSerializer.Deserialize<Object>(json);
            return characters;
        }
    }
}
