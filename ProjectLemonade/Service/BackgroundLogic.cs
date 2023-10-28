using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Interfaces;
using ProjectLemonade.Model.Entities;
using ProjectLemonade.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Service
{
    public static class BackgroundLogic
    {
        public static void PickUpStartingBackgrounds(ICharacter character)
        {
            character.CharacterBackgrounds.Clear();

            List<int> freebackgrounds = OrderLogic.GetCharacterOrder(character).FreeBackgrounds;
            int mainbackground = OrderLogic.GetCharacterOrder(character).Background;

            character.CharacterBackgrounds.Add(mainbackground);
            foreach (var item in freebackgrounds)
            {
                character.CharacterBackgrounds.Add(item);
            }
        }
        
        public static void PickUpBackground(int backgroundID, ICharacter character)
        {
            character.CharacterBackgrounds.Add(backgroundID);
        }
    }
}
