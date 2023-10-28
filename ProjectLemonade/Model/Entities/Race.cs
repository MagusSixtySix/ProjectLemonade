using ProjectLemonade.Interfaces;
using ProjectLemonade.Model.Interfaces;
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
        private List<IRaceBaseAttribute> baseMaxAttributes;
        private List<int> classes;
        private List<IEducation> educations;
        private int iD;

        public Race (string name, List<IRaceBaseAttribute> baseMaxAttributes, List<int> classes, List<IEducation> educations, int iD)
        {
            Name = name;
            BaseMaxAttributes = baseMaxAttributes;
            Classes = classes;
            Educations = educations;
            ID = iD;
            Name = name;
            BaseMaxAttributes = baseMaxAttributes;
            Classes = classes;
            Educations = educations;
            ID = iD;
        }

        public string Name { get => name; set => name = value; }
        public List<IRaceBaseAttribute> BaseMaxAttributes { get => baseMaxAttributes; set => baseMaxAttributes = value; }
        public List<int> Classes { get => classes; set => classes = value; }
        public List<IEducation> Educations { get => educations; set => educations = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
