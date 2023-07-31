using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Attribute : IAttribute
    {
        private string name;
        private int maxValue;
        private int currentValue;
        private int valueFromCCP;
        private int modifyCurrentValue;
        private int modifyMaxValue;

        public string Name { get => name; set => name = value; }
        public int MaxValue { get => maxValue; set => maxValue = value; }
        public int CurrentValue { get => currentValue; set => currentValue = value; }
        public int ValueFromCCP { get => valueFromCCP; set => valueFromCCP = value; }
        public int ModifyCurrentValue { get => modifyCurrentValue; set => modifyCurrentValue = value; }
        public int ModifyMaxValue { get => modifyMaxValue; set => modifyMaxValue = value; }
    }   
}
