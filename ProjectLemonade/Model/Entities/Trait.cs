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

        public Trait(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
