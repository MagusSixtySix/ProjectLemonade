using ProjectLemonade.Interfaces;
using ProjectLemonade.Model.Entities;
using ProjectLemonade.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class CharacterAttribute : ICharacterAttribute
    {
        private IBaseAttribute attribute;
        private int maxValue;
        private int valueAtLvl1;
        private int modifyValue;
        private int modifyMaxValue;

        public CharacterAttribute(IBaseAttribute attribute, int maxValue, int valueAtLvl1, int modifyValue, int modifyMaxValue)
        {
            Attribute = attribute;
            MaxValue = maxValue;
            ValueAtLvl1 = valueAtLvl1;
            ModifyValue = modifyValue;
            ModifyMaxValue = modifyMaxValue;
        }

        public IBaseAttribute Attribute { get => attribute; set => attribute = value; }
        public int MaxValue { get => maxValue; set => maxValue = value; }
        public int ValueAtLvl1 { get => valueAtLvl1; set => valueAtLvl1 = value; }
        public int ModifyValue { get => modifyValue; set => modifyValue = value; }
        public int ModifyMaxValue { get => modifyMaxValue; set => modifyMaxValue = value; }
        public int GetCurrentValue() { return ValueAtLvl1 +  ModifyValue; }
        public int GetCurrentMaxValue() { return MaxValue + ModifyMaxValue; }
    }   
}
