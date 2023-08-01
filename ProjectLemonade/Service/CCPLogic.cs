using ProjectLemonade.Interfaces;
using ProjectLemonade.Repository;
using ProjectLemonade.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Model.Entities;

namespace ProjectLemonade.Service
{
    static internal class CCPLogic
    {
        static int maxCCP = 50;
        public static int GetCCP(ICharacter character)
        {
            return (maxCCP - GetSpentCCPOnBackgrounds(character)) * character.CharacterLevel + 
                character.CharacterAttributes.Find(x => x.Name == "Intelligence").CurrentValue; //current value nem jó! a LVL 1-es valuenak kell lennie!
        }

        public static int GetSpentCCPOnBackgrounds(ICharacter character)
        {
            int sumOfSpentCCP = 0;
            BackgroundList backgrounds = (BackgroundList)JsonFileHandler.ReadJsonToObject(@"backgrounds.json");
            foreach (var item in character.CharacterBackgrounds)
            {
                sumOfSpentCCP += backgrounds.Backgrounds.Find(x => x.ID == item).CCPCost;
            }
            return sumOfSpentCCP;
        }
    }
}
