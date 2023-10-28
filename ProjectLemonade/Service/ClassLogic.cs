using ProjectLemonade.Interfaces;
using ProjectLemonade.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Service
{
    public static class ClassLogic
    {
        public static void PickClass(int classID, ICharacter character)
        {
            character.CharacterClass = classID;
        }

        public static IPlayerClass GetCharacterClass(ICharacter character)
        {
            return JsonFileHandler.GetListFromFile<IPlayerClass>("classes").
                Find(x => x.ID == character.CharacterClass);
        }
    }
}
