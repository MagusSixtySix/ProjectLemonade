using ProjectLemonade.Interfaces;
using ProjectLemonade.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Service
{
    public static class OrderLogic
    {
        public static void PickOrder(int orderID, ICharacter character)
        {
            character.CharacterOrder = orderID;
        }

        public static IOrder GetCharacterOrder(ICharacter character)
        {
            return JsonFileHandler.GetListFromFile<IOrder>("orders").
                Find(x => x.ID == character.CharacterOrder);
        }
    }
}
