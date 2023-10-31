using ProjectLemonade.Interfaces;
using ProjectLemonade.Model.Entities;
using ProjectLemonade.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Mastery : IMastery
    {
        private string name;
        private int iD;
        private int difficulity;
        private List<int> strongPrerequisites;
        private List<int> weakPrerequisites;
        private List<int> requiredAttributes;

        public Mastery() { }
        public Mastery(string name, int iD, int difficulity, List<int> strongPrerequisites, List<int> weakPrerequisites, List<int> requiredAttributes)
        {
            Name = name;
            ID = iD;
            Difficulity = difficulity;
            StrongPrerequisites = strongPrerequisites;
            WeakPrerequisites = weakPrerequisites;
            RequiredAttributes = requiredAttributes;
        }

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
        public int Difficulity { get => difficulity; set => difficulity = value; }
        public List<int> StrongPrerequisites { get => strongPrerequisites; set => strongPrerequisites = value; }
        public List<int> WeakPrerequisites { get => weakPrerequisites; set => weakPrerequisites = value; }
        public List<int> RequiredAttributes { get => requiredAttributes; set => requiredAttributes = value; }
    }
}
