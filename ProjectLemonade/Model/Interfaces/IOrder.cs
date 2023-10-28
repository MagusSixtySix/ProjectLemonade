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
        int ID { get; set; }
        int Background { get; set; }
        List<int> FreeBackgrounds { get; set; }
        List<IEducation> Educations { get; set; }
    }
}
