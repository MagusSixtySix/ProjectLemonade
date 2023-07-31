using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface IOrder
    {
        string Name { get; set; }
        List<IEducation> Educations { get; set; }
    }
}
