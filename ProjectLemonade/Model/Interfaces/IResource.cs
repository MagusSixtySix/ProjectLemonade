using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface IResource
    {
        string Name { get; set; }
        int BaseValue { get; set; }
        int ValueFromCCP { get; set; }
    }
}
