using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class CombatStat : ICombatStat
    {
        private string name;
        private int id;
        private int baseValue;
        private int valueFromCCP;

        public CombatStat(string name, int id, int baseValue, int valueFromCCP)
        {
            Name = name;
            ID = id;
            BaseValue = baseValue;
            ValueFromCCP = valueFromCCP;
        }

        public string Name { get => name; set => name = value; }
        public int ID { get => id; set => id = value; }
        public int BaseValue { get => baseValue; set => baseValue = value; }
        public int ValueFromCCP { get => valueFromCCP; set => valueFromCCP = value; }

        public int GetValue()
        {
            return BaseValue + ValueFromCCP;
        }
    }
}
