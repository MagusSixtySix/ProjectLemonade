using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface ICharacterAttribute
    {
        string Name { get; set; }
        int MaxValue { get; set; }
        int CurrentValue { get; set; }
        int ValueFromCCP { get; set; }
        int ModifyCurrentValue { get; set; }
        int ModifyMaxValue { get; set; }
    }
}
