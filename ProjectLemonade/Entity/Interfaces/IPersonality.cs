using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface IPersonality
    {
        ITrait MainTrait { get; set; }
        ITrait SecondaryTrait { get; set; }
    }
}
