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
    public static class EducationLogic
    {
        public static int GetEducationLevel(int masteryID, ICharacter character)
        {
            int level = 0;
            //return level;

            if ( GetRaceEducation(masteryID, character) != null )
            {
                level = GetRaceEducation(masteryID, character).EducationLevel;
            }

            if ( GetOrderEducation(masteryID, character) != null )
            {
                if (GetOrderEducation(masteryID, character).EducationLevel >
                    GetRaceEducation(masteryID, character).EducationLevel)
                {
                    level = GetOrderEducation(masteryID, character).EducationLevel;
                }
            }

            return level;
        }

        private static IEducation GetRaceEducation(int masteryID, ICharacter character)
        {
            List<IRace> races = JsonFileHandler.GetListFromFile<IRace>("races");
            int characterRace = character.CharacterRace;

            if (races.Find(x => x.ID == characterRace).Educations == null)
            {
                return null;
            }
            return races.Find(x => x.ID == characterRace).Educations.Find(x => x.Mastery == masteryID);
        }

        private static IEducation GetOrderEducation(int masteryID, ICharacter character)
        {
            List<IOrder> orders = JsonFileHandler.GetListFromFile<IOrder>("orders");
            int characterOrder = character.CharacterOrder;

            if (orders.Find(x => x.ID == characterOrder).Educations == null)
            {
                return null;
            }
            return orders.Find(x => x.ID == characterOrder).Educations.Find(x => x.Mastery == masteryID);
        }
    }
}
