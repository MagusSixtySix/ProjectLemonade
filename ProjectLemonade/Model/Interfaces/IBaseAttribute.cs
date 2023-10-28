using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Model.Interfaces
{
    public interface IBaseAttribute
    {
        string Name { get; set; }
        int ID { get; set; }
    }
}
