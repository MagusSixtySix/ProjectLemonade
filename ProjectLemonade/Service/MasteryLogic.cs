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
    public static class MasteryLogic
    {
        public static List<int> IncreaseMastery(int masteryID, ICharacter character)
        {
            int costOfLevelUp = GetTotalCostOfLevelUp(masteryID, character);
            List<int> increasedMasteryIDs = new List<int>();

            if (character.CharacterCreationPoints - costOfLevelUp > 0)
            {
                character.CharacterCreationPoints -= costOfLevelUp;
                increasedMasteryIDs.AddRange(LevelUpMastery(masteryID, character));
            }
            RemoveLvl0Masteries(character);
            return increasedMasteryIDs;
        }
        private static List<int> LevelUpMastery(int masteryID, ICharacter character)
        {
            IMastery mastery = GetMastery(masteryID);
            int masteryLevel = character.CharacterMasteries.Find(x => x.ID == masteryID).Level += 1;
            List<int> increasedMasteryIDs = new List<int>();
            increasedMasteryIDs.Add(masteryID);

            if (mastery.StrongPrerequisites != null)
            {
                    foreach (var item in mastery.StrongPrerequisites)
                    {
                        if (character.CharacterMasteries.Find(x => x.ID == item).Level < masteryLevel)
                        {
                            increasedMasteryIDs.AddRange(LevelUpMastery(item, character));
                        }
                    }
            }
            if (mastery.WeakPrerequisites != null)
            {
                    foreach (var item in mastery.WeakPrerequisites)
                    {
                        if (masteryLevel - character.CharacterMasteries.Find(x => x.ID == item).Level > 1)
                        {
                            increasedMasteryIDs.AddRange(LevelUpMastery(item, character));
                        }
                    }
            }
            return increasedMasteryIDs;
        }
        private static int GetTotalCostOfLevelUp(int masteryID, ICharacter character)
        {
            int totalCostOfLevelUp = 0;

            if (character.CharacterMasteries.Find(x => x.ID == masteryID) == null)
            {
                character.CharacterMasteries.Add(new CharacterMasteries(masteryID, 0));
            }

            totalCostOfLevelUp += GetCostOfLevelUpMastery(masteryID, character);
            IMastery mastery = GetMastery(masteryID);
            int masteryLevel = character.CharacterMasteries.Find(x => x.ID == masteryID).Level;

            if (mastery.StrongPrerequisites != null)
            {
                foreach (var item in mastery.StrongPrerequisites)
                {
                    if (character.CharacterMasteries.Find(x => x.ID == item) == null)
                    {
                        character.CharacterMasteries.Add(new CharacterMasteries(item, 0));
                    }
                    if (character.CharacterMasteries.Find(x => x.ID == item).Level < (masteryLevel +1))
                    {
                        totalCostOfLevelUp += GetTotalCostOfLevelUp(item, character);
                    }
                }
            }
            if (mastery.WeakPrerequisites != null)
            {
                foreach (var item in mastery.WeakPrerequisites)
                {
                    if (character.CharacterMasteries.Find(x => x.ID == item) == null)
                    {
                        character.CharacterMasteries.Add(new CharacterMasteries(item, 0));
                    }
                    if ((masteryLevel + 1) - character.CharacterMasteries.Find(x => x.ID == item).Level > 1)
                    {
                        totalCostOfLevelUp += GetTotalCostOfLevelUp(item, character);
                    }
                }
            }
            return totalCostOfLevelUp;
        }
        private static int GetCostOfLevelUpMastery (int masteryID, ICharacter character)
        {
            
            int educationLevel = EducationLogic.GetEducationLevel(masteryID, character);
            int educationBonus = GetEducationBonus(educationLevel);
            return CostModifiedByEducation(educationBonus, masteryID, educationLevel, character);
        }

        private static int CostModifiedByEducation(int educationBonus,int masteryID, int educationLevel, ICharacter character)
        {
            IMastery mastery = GetMastery(masteryID);
            int targetLevel = character.CharacterMasteries.Find(x => x.ID == masteryID).Level + 1;

            if (educationLevel >= targetLevel)
            {
                int costModifiedByEducation = GetCCPCost(targetLevel, mastery.Difficulity) - educationBonus;

                if ( costModifiedByEducation <= 1) { return 1; }
                else { return costModifiedByEducation; }
            }
            else { return GetCCPCost(targetLevel, mastery.Difficulity); }
        }

        public static void DecreaseMastery(List<int> list, ICharacter character)
        {
            List<IMastery> masteryList = JsonFileHandler.GetListFromFile<IMastery>("masteries");

            foreach (var item in list)
            {
                IMastery mastery = masteryList.Find(x => x.ID == item);
                int currentLevel = character.CharacterMasteries.Find(x => x.ID == item).Level;
                int educationLevel = EducationLogic.GetEducationLevel(item, character);
                int educationBonus = GetEducationBonus(educationLevel);

                if (educationLevel >= currentLevel)
                {
                    character.CharacterCreationPoints += GetCCPCost(currentLevel, mastery.Difficulity)-educationBonus;
                }else
                {
                    character.CharacterCreationPoints += GetCCPCost(currentLevel, mastery.Difficulity);
                }
                character.CharacterMasteries.Find(x => x.ID == item).Level -= 1;
                RemoveLvl0Masteries(character);
            }
        }
        private static int GetEducationBonus(int educationLevel)
        {
            if (educationLevel > 0 && educationLevel <= 3) { return 1; }
            else if (educationLevel == 4) { return 2; }
            else if (educationLevel == 5) { return 3; }
            else return 0;
        }
        private static int GetCCPCost(int masteryLevel, int difficulity)
        {
            switch (difficulity)
            {
                case 1:
                    switch (masteryLevel)
                    {
                        case 1: return 1;
                        case 2: return 2;
                        case 3: return 5;
                        case 4: return 7;
                        case 5: return 10;
                        default: return 0;
                    }
                case 2:
                    switch (masteryLevel)
                    {
                        case 1: return 1;
                        case 2: return 4;
                        case 3: return 5;
                        case 4: return 10;
                        case 5: return 10;
                        default: return 0;
                    }
                case 3:
                    switch (masteryLevel)
                    {
                        case 1: return 2;
                        case 2: return 6;
                        case 3: return 7;
                        case 4: return 15;
                        case 5: return 15;
                        default: return 0;
                    }
                case 4:
                    switch (masteryLevel)
                    {
                        case 1: return 3;
                        case 2: return 7;
                        case 3: return 10;
                        case 4: return 15;
                        case 5: return 20;
                        default: return 0;
                    }
                default: return 0;
            }
        }
        private static IMastery GetMastery(int masteryID)
        {
            return JsonFileHandler.GetListFromFile<IMastery>("masteries").Find(x => x.ID == masteryID);
        }
        private static void RemoveLvl0Masteries(ICharacter character)
        {
            character.CharacterMasteries.RemoveAll(x => x.Level == 0);
        }
    }
}
