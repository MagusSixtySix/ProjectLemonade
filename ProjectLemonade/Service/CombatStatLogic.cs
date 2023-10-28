using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Interfaces;
using ProjectLemonade.Model.Interfaces;
using ProjectLemonade.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Service
{
    public static class CombatStatLogic
    {
        public static void PopulateCombatStats(ICharacter character)
        {
            List<ICombatStat> combatStats = JsonFileHandler.GetListFromFile<ICombatStat>("combatstats");

            character.CharacterCombatStats.Clear();

            foreach (var item in combatStats)
            {
                character.CharacterCombatStats.Add(item);
            }
        }

        public static void UpdateBaseValueOfCombatStats(ICharacter character)
        {
            ICharacterAttribute strength = character.CharacterAttributes.Find(x => x.Attribute.ID == 1);
            ICharacterAttribute speed = character.CharacterAttributes.Find(x => x.Attribute.ID == 2);
            ICharacterAttribute dexterity = character.CharacterAttributes.Find(x => x.Attribute.ID == 3);
            ICharacterAttribute perception = character.CharacterAttributes.Find(x => x.Attribute.ID == 4);

            foreach (var item in character.CharacterCombatStats)
            {
                switch (item.ID)
                {
                    case 1: item.BaseValue = perception.GetCurrentValue() + speed.GetCurrentValue(); break;
                    case 2: item.BaseValue = dexterity.GetCurrentValue() + speed.GetCurrentValue() + strength.GetCurrentValue(); break;
                    case 3: item.BaseValue = perception.GetCurrentValue() + dexterity.GetCurrentValue(); break;
                    case 4: item.BaseValue = dexterity.GetCurrentValue() + speed.GetCurrentValue() + 60; break;
                }
            }
        }

        public static bool IncreaseCombatStatWithCCP(int combatStatID, ICharacter character)
        {
            ICombatStat combatStat = character.CharacterCombatStats.Find(x => x.ID == combatStatID);
            int ccp = character.CharacterCreationPoints;

            if (ccp >= 2)
            {
                combatStat.ValueFromCCP += 1;
                ccp -= 2;
                return true;
            }
            return false;
        }

        public static bool DecreaseCombatStatWithCCP(int combatStatID, ICharacter character)
        {
            ICombatStat combatStat = character.CharacterCombatStats.Find(x => x.ID == combatStatID);
            int ccp = character.CharacterCreationPoints;

            if (combatStat.ValueFromCCP != 0)
            {
                combatStat.ValueFromCCP -= 1;
                ccp += 2;
                return true;
            }
            return false;
        }
    }
}
