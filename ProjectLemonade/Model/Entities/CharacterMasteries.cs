using ProjectLemonade.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Model.Entities
{
    internal class CharacterMasteries : ICharacterMasteries
    {
        private int iD;
        private int level;

        public CharacterMasteries (int iD, int level)
        {
            ID = iD;
            Level = level;
        }
        public int ID { get => iD; set => iD = value; }
        public int Level { get => level; set => level = value; }
    }
}
