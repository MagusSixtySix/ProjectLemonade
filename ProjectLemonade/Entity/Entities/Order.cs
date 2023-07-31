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
        private List<IEducation> educations;

        public string Name { get => name; set => name = value; }
        public List<IEducation> Educations { get => educations; set => educations = value; }
    }
}
