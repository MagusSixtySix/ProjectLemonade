using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Interfaces;
using ProjectLemonade.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Service
{
    public static class PersonalityLogic
    {
        public static void PickTrait(int maintraitID, int secondaryTraitID, ICharacter character) 
        {
            character.CharacterPersonality = new Personality(GetTrait(maintraitID), GetTrait(secondaryTraitID));
        }

        private static ITrait GetTrait(int traitID)
        {
            return JsonFileHandler.GetListFromFile<ITrait>("traits").Find(x => x.ID == traitID);
        }
    }
}
