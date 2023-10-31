using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Interfaces;
using ProjectLemonade.Model.Entities;
using ProjectLemonade.Model.Interfaces;
using ProjectLemonade.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Service
{
    public static class AttributeLogic
    {
        public static void PopulateAttributes(ICharacter character)
        {
            List<IRace> races = JsonFileHandler.GetListFromFile<IRace>("races");
            List<IBaseAttribute> baseAttributes = JsonFileHandler.GetListFromFile<IBaseAttribute>("attributes");

            character.CharacterAttributes = new List<ICharacterAttribute>();

            foreach (var item in baseAttributes)
            {
                character.CharacterAttributes.Add(new CharacterAttribute(item, 
                    races.Find(x => x.ID == character.CharacterRace).BaseMaxAttributes.Find(x => x.ID
                    == item.ID).MaxLevel, 13, 0, 0));
            }
        }

        private static void UpdateStats(ICharacter character)
        {
            CombatStatLogic.UpdateBaseValueOfCombatStats(character);
            ResourceLogic.UpdateBaseValueOfResources(character);
        }

        public static bool IncreaseAttribute(int attributeToIncreaseID, ICharacter character, bool isFree)
        {
            ICharacterAttribute attribute = character.CharacterAttributes.Find(x => x.Attribute.ID == attributeToIncreaseID);

            if (attribute.GetCurrentValue() >= attribute.GetCurrentMaxValue())
            {
                return false;
            }

            if (character.CharacterLevel == 1)
            {
                attribute.ValueAtLvl1 += 1;
                UpdateStats(character);
                return true;
            } else if (isFree)
            {
                attribute.ModifyValue += 1;
                UpdateStats(character);
                return true;
            } else if (character.CharacterCreationPoints >= 20)
            {
                character.CharacterCreationPoints -= 20;
                attribute.ModifyValue += 1;
                UpdateStats(character);
                return true;
            } else return false;
        }

        public static bool DecreaseAttribute(int attributeToDecreaseID, ICharacter character, bool isFree)
        {
            ICharacterAttribute attribute = character.CharacterAttributes.Find(x => x.Attribute.ID == attributeToDecreaseID);

            if (attribute.GetCurrentValue() <= 10)
            {
                return false;
            }

            if (character.CharacterLevel == 1)
            {
                attribute.ValueAtLvl1 -= 1;
                UpdateStats(character);
                return true;
            } else if (isFree)
            {
                attribute.ModifyValue -= 1;
                UpdateStats(character);
                return true;
            } else
            {
                attribute.ModifyValue -= 1;
                character.CharacterCreationPoints += 20;
                UpdateStats(character);
                return true;
            }
        }
    }
}
