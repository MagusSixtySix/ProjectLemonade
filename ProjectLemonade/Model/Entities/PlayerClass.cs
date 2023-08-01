using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class PlayerClass : IPlayerClass
    {
        private string name;
        private List<IOrder> orders;
        private int iD;

        public string Name { get => name; set => name = value; }
        public List<IOrder> Orders { get => orders; set => orders = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
