using ProjectLemonade.Model.Entities;
using ProjectLemonade.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface ICharacterAttribute
    {
        IBaseAttribute Attribute { get; set; }
        int MaxValue { get; set; }
        int ValueAtLvl1 { get; set; }
        int ModifyValue { get; set; }
        int ModifyMaxValue { get; set; }

        int GetCurrentValue();
        int GetCurrentMaxValue();
    }
}
