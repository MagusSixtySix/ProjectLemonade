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
    public static class CCPLogic
    {
        static int maxCCP = 50;
        public static int GetCCP(ICharacter character)
        {
            return (maxCCP - GetSpentCCPOnBackgrounds(character)) * character.CharacterLevel +
                character.CharacterAttributes.Find(x => x.Attribute.ID == 8).ValueAtLvl1;
        }

        public static int GetSpentCCPOnBackgrounds(ICharacter character)
        {
            int sumOfSpentCCP = 0;
            List<IBackground> backgrounds = JsonFileHandler.GetListFromFile<IBackground>("backgrounds");
            List<int> freebackgrounds = OrderLogic.GetCharacterOrder(character).FreeBackgrounds;

            foreach (var item in character.CharacterBackgrounds)
            {
                if (!freebackgrounds.Contains(item))
                {
                    sumOfSpentCCP += backgrounds.Find(x => x.ID == item).CCPCost;
                }
            }
            return sumOfSpentCCP;
        }
    }
}
