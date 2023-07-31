using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }
        ItemType Type { get; set; }
        double StructurePoints { get; set; }
        double Weight { get; set; }
        double Price { get; set; }
    }

    public enum ItemType
    {
        weapon,
        shield,
        armor,

        defaultItem,
        numberOfItemTypes,
    }
}
