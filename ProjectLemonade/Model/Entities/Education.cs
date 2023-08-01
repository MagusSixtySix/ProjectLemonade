using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Education : IEducation
    {
        private IMastery mastery;
        private int educationLevel;

        public IMastery Mastery { get => mastery; set => mastery = value; }
        public int EducationLevel { get => educationLevel; set => educationLevel = value; }
    }
}
