using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Model.Interfaces
{
    public interface IRaceBaseAttribute
    {
        int ID { get; set; }

        int MaxLevel { get; set; }
    }
}
