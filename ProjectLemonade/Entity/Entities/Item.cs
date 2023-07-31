using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Item : IItem
    {
        private string name;
        private ItemType type;
        private double structurePoints;
        private double weight;
        private double price;

        public Item(string name, ItemType type, double structurePoints, double weight, double price)
        {
            Name = name;
            Type = type;
            StructurePoints = structurePoints;
            Weight = weight;
            Price = price;
        }

        public string Name { get => name; set => name = value; }
        public ItemType Type { get => type; set => type = value; }
        public double StructurePoints { get => structurePoints; set => structurePoints = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Price { get => price; set => price = value; }
    }
}
