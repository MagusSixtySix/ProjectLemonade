using ProjectLemonade.Interfaces;
using ProjectLemonade.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Service
{
    public static class RaceLogic
    {
        public static void PickRace(int raceID, ICharacter character)
        {
            character.CharacterRace = raceID;
        }

        public static IRace GetCharacterRace(ICharacter character)
        {
            return JsonFileHandler.GetListFromFile<IRace>("races").
               Find(x => x.ID == character.CharacterRace);
        }
    }
}
