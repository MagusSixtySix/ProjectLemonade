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
        private int baseValue;
        private int valueFromCCP;

        public string Name { get => name; set => name = value; }
        public int BaseValue { get => baseValue; set => baseValue = value; }
        public int ValueFromCCP { get => valueFromCCP; set => valueFromCCP = value; }
    }
}
