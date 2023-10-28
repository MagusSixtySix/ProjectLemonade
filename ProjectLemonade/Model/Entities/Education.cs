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
        private int mastery;
        private int educationLevel;

        public Education(int mastery, int educationLevel) 
        {
            Mastery = mastery;
            EducationLevel = educationLevel;
        }

        public int Mastery { get => mastery; set => mastery = value; }
        public int EducationLevel { get => educationLevel; set => educationLevel = value; }
    }
}
