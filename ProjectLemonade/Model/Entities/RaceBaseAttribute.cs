using ProjectLemonade.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Model.Entities
{
    internal class RaceBaseAttribute : IRaceBaseAttribute
    {
        private int iD;

        private int maxLevel;

        public RaceBaseAttribute(int iD, int maxLevel)
        {
            ID = iD;
            MaxLevel = maxLevel;
        }

        public int ID { get => iD; set => iD = value; }
        public int MaxLevel { get => maxLevel; set => maxLevel = value; }
    }
}
