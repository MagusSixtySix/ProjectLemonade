using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface IMastery
    {
        string Name { get; set; }
        int ID { get; set; }
        int CCPCostLvl1 { get; set; }
        int CCPCostLvl2 { get; set; }
        int CCPCostLvl3 { get; set; }
        int CCPCostLvl4 { get; set; }
        int CCPCostLvl5 { get; set; }
        int Difficulity { get; set; }
        List<IMastery> StrongPrerequisites { get; set; }
        List<IMastery> WeakPrerequisites { get; set; }
        List<IAttribute> RequiredAttributes { get; set; }
        int MasteryLevel { get; set; }
    }
}
