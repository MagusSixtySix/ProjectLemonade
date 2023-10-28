using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Order : IOrder
    {
        private string name;
        private int iD;
        private int background;
        private List<int> freeBackgrounds;
        private List<IEducation> educations;

        public Order(string name, int iD, List<IEducation> educations, int background, List<int> freeBackgrounds) 
        {
            Name = name;
            Educations = educations;
            ID = iD;
            Background = background;
            FreeBackgrounds = freeBackgrounds;
        }
        public string Name { get => name; set => name = value; }
        public List<IEducation> Educations { get => educations; set => educations = value; }
        public int ID { get => iD; set => iD = value; }
        public int Background { get => background; set => background = value; }
        public List<int> FreeBackgrounds { get => freeBackgrounds; set => freeBackgrounds = value; }
    }
}
