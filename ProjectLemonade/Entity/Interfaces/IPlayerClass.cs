using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface IPlayerClass
    {
        string Name { get; set; }
        List<IOrder> Orders { get; set; }
    }
}
