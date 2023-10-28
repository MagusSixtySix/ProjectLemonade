using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Resource : IResource
    {
        private string name;
        private int iD;
        private int baseValue;
        private int valueFromCCP;

        public Resource(string name, int iD, int baseValue, int valueFromCCP)
        {
            Name = name;
            ID = iD;
            BaseValue = baseValue;
            ValueFromCCP = valueFromCCP;
        }

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
        public int BaseValue { get => baseValue; set => baseValue = value; }
        public int ValueFromCCP { get => valueFromCCP; set => valueFromCCP = value; }

        public int GetValue()
        {
            return BaseValue + ValueFromCCP;
        }
    }
}
