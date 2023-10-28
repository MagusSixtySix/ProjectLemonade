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
        private int cCPCostLvl1;
        private int cCPCostLvl2;
        private int cCPCostLvl3;
        private int cCPCostLvl4;
        private int cCPCostLvl5;
        private int difficulity;
        private List<int> strongPrerequisites;
        private List<int> weakPrerequisites;
        private List<int> requiredAttributes;

        public Mastery() { }
        public Mastery(string name, int iD, int cCPCostLvl1, int cCPCostLvl2, int cCPCostLvl3, int cCPCostLvl4, int cCPCostLvl5, int difficulity, List<int> strongPrerequisites, List<int> weakPrerequisites, List<int> requiredAttributes)
        {
            Name = name;
            ID = iD;
            CCPCostLvl1 = cCPCostLvl1;
            CCPCostLvl2 = cCPCostLvl2;
            CCPCostLvl3 = cCPCostLvl3;
            CCPCostLvl4 = cCPCostLvl4;
            CCPCostLvl5 = cCPCostLvl5;
            Difficulity = difficulity;
            StrongPrerequisites = strongPrerequisites;
            WeakPrerequisites = weakPrerequisites;
            RequiredAttributes = requiredAttributes;
        }

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
        public int CCPCostLvl1 { get => cCPCostLvl1; set => cCPCostLvl1 = value; }
        public int CCPCostLvl2 { get => cCPCostLvl2; set => cCPCostLvl2 = value; }
        public int CCPCostLvl3 { get => cCPCostLvl3; set => cCPCostLvl3 = value; }
        public int CCPCostLvl4 { get => cCPCostLvl4; set => cCPCostLvl4 = value; }
        public int CCPCostLvl5 { get => cCPCostLvl5; set => cCPCostLvl5 = value; }
        public int Difficulity { get => difficulity; set => difficulity = value; }
        public List<int> StrongPrerequisites { get => strongPrerequisites; set => strongPrerequisites = value; }
        public List<int> WeakPrerequisites { get => weakPrerequisites; set => weakPrerequisites = value; }
        public List<int> RequiredAttributes { get => requiredAttributes; set => requiredAttributes = value; }
    }
}
