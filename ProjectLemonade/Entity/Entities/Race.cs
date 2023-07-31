using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Race : IRace
    {
        private string name;
        private int[] baseMaxAttributes;
        private List<IPlayerClass> classes;
        private List<IEducation> educations;
        private int iD;

        public string Name { get => name; set => name = value; }
        public int[] BaseMaxAttributes { get => baseMaxAttributes; set => baseMaxAttributes = value; }
        public List<IPlayerClass> Classes { get => classes; set => classes = value; }
        public List<IEducation> Educations { get => educations; set => educations = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
