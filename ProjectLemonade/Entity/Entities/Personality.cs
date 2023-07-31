using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Personality : IPersonality
    {
        private ITrait mainTrait;
        private ITrait secondaryTrait;

        public Personality(ITrait mainTrait, ITrait secondaryTrait)
        {
            MainTrait = mainTrait;
            SecondaryTrait = secondaryTrait;
        }

        public ITrait MainTrait { get => mainTrait; set => mainTrait = value; }
        public ITrait SecondaryTrait { get => secondaryTrait; set => secondaryTrait = value; }
    }
}
