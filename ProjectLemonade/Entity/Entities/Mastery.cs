using ProjectLemonade.Interfaces;
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
        private int cCPCostLvl1;
        private int cCPCostLvl2;
        private int cCPCostLvl3;
        private int cCPCostLvl4;
        private int cCPCostLvl5;
        private int difficulity;
        private List<IMastery> strongPrerequisites;
        private List<IMastery> weakPrerequisites;
        private List<IAttribute> requiredAttributes;
        private int masteryLevel;
        private int iD;

        public string Name { get => name; set => name = value; }
        public int CCPCostLvl1 { get => cCPCostLvl1; set => cCPCostLvl1 = value; }
        public int CCPCostLvl2 { get => cCPCostLvl2; set => cCPCostLvl2 = value; }
        public int CCPCostLvl3 { get => cCPCostLvl3; set => cCPCostLvl3 = value; }
        public int CCPCostLvl4 { get => cCPCostLvl4; set => cCPCostLvl4 = value; }
        public int CCPCostLvl5 { get => cCPCostLvl5; set => cCPCostLvl5 = value; }
        public int Difficulity { get => difficulity; set => difficulity = value; }
        public List<IMastery> StrongPrerequisites { get => strongPrerequisites; set => strongPrerequisites = value; }
        public List<IMastery> WeakPrerequisites { get => weakPrerequisites; set => weakPrerequisites = value; }
        public List<IAttribute> RequiredAttributes { get => requiredAttributes; set => requiredAttributes = value; }
        public int MasteryLevel { get => masteryLevel; set => masteryLevel = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
