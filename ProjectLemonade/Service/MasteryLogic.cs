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
            if (educationLevel > 0 && educationLevel <= 3) { return CostModifiedByEducation(1, masteryID, educationLevel, character); }
            else if (educationLevel == 4) { return CostModifiedByEducation(2, masteryID, educationLevel, character); }
            else if (educationLevel == 5) { return CostModifiedByEducation(3, masteryID, educationLevel, character); }
            else return CostModifiedByEducation(0, masteryID, educationLevel, character);
        }

        private static int CostModifiedByEducation(int educationBonus,int masteryID, int educationLevel, ICharacter character)
        {
            IMastery mastery = GetMastery(masteryID);
            int currentLevel = character.CharacterMasteries.Find(x => x.ID == masteryID).Level;

            switch (currentLevel + 1)
            {
                case 1:
                    if (educationLevel >= currentLevel + 1)
                    {
                        if (mastery.CCPCostLvl1 - educationBonus <= 1) { return 1; }
                        else { return mastery.CCPCostLvl1 - educationBonus; }
                    }
                    else { return mastery.CCPCostLvl1; }
                case 2:
                    if (educationLevel >= currentLevel + 1)
                    {
                        if (mastery.CCPCostLvl2 - mastery.CCPCostLvl1 - educationBonus <= 1) { return 1; }
                        else { return mastery.CCPCostLvl2 - mastery.CCPCostLvl1 - educationBonus; }
                    }
                    else { return mastery.CCPCostLvl2 - mastery.CCPCostLvl1; }
                case 3:
                    if (educationLevel >= currentLevel + 1)
                    {
                        if (mastery.CCPCostLvl3 - mastery.CCPCostLvl2 - educationBonus <= 1) { return 1; }
                        else { return mastery.CCPCostLvl3 - mastery.CCPCostLvl2 - educationBonus; }
                    }
                    else { return mastery.CCPCostLvl3 - mastery.CCPCostLvl2; }
                case 4:
                    if (educationLevel >= currentLevel + 1)
                    {
                        if (mastery.CCPCostLvl4 - mastery.CCPCostLvl3 - educationBonus <= 1) { return 1; }
                        else { return mastery.CCPCostLvl4 - mastery.CCPCostLvl3 - educationBonus; }
                    }
                    else { return mastery.CCPCostLvl4 - mastery.CCPCostLvl3; }
                case 5:
                    if (educationLevel >= currentLevel + 1)
                    {
                        if (mastery.CCPCostLvl5 - mastery.CCPCostLvl4 - educationBonus <= 1) { return 1; }
                        else { return mastery.CCPCostLvl5 - mastery.CCPCostLvl4 - educationBonus; }
                    }
                    else { return mastery.CCPCostLvl5 - mastery.CCPCostLvl4; }
                default: return 0;
            }
        }

        private static IMastery GetMastery(int masteryID)
        {
            return JsonFileHandler.GetListFromFile<IMastery>("masteries").Find(x => x.ID == masteryID);
        }

        public static void DecreaseMastery(List<int> list, ICharacter character)
        {
            List<IMastery> masteryList = JsonFileHandler.GetListFromFile<IMastery>("masteries");

            foreach (var item in list)
            {
                IMastery mastery = masteryList.Find(x => x.ID == item);
                switch (character.CharacterMasteries.Find(x => x.ID == item).Level)
                {
                    case 1: { character.CharacterCreationPoints += mastery.CCPCostLvl1; break; }
                    case 2: { character.CharacterCreationPoints += mastery.CCPCostLvl2 - mastery.CCPCostLvl1; break; }
                    case 3: { character.CharacterCreationPoints += mastery.CCPCostLvl3 - mastery.CCPCostLvl2; break; }
                    case 4: { character.CharacterCreationPoints += mastery.CCPCostLvl4 - mastery.CCPCostLvl3; break; }
                    case 5: { character.CharacterCreationPoints += mastery.CCPCostLvl5 - mastery.CCPCostLvl4; break; }
                }
                character.CharacterMasteries.Find(x => x.ID == item).Level -= 1;
            }
        }
    }
}
