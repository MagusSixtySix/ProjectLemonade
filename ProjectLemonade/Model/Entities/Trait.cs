using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Trait : ITrait
    {
        private string name;
        private int iD;

        public Trait(string name, int iD)
        {
            Name = name;
            ID = iD;
        }

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
