using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Background : IBackground
    {
        private string name;
        private int cCPCost;
        private int iD;

        public string Name { get => name; set => name = value; }
        public int CCPCost { get => cCPCost; set => cCPCost = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
