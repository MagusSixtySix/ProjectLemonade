using ProjectLemonade.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Model.Entities
{
    internal class BaseAttribute : IBaseAttribute
    {
        private string name;
        private int iD;

        public BaseAttribute(string name, int iD) 
        {
            Name = name;
            ID = iD;
        }

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
