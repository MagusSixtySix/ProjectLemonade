﻿using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Interfaces;
using ProjectLemonade.Model.Entities;
using ProjectLemonade.Model.Interfaces;
using ProjectLemonade.Repository;
using ProjectLemonade.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ProjectLemonade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileWriter.WriteDataFiles();

            Character test = (Character)JsonFileHandler.ReadJsonToObject(@JsonFileHandler.GetCharacterFileName("TestSubject"));
            test.CharacterCreationPoints = 1000;
            test.CharacterRace = 2;
            test.CharacterClass = 3;
            test.CharacterOrder = 5;

            CombatStatLogic.PopulateCombatStats(test);
            ResourceLogic.PopulateResources(test);
            AttributeLogic.PopulateAttributes(test);
            test.CharacterMasteries = new List<ICharacterMasteries>();

            LinkedList<List<int>> allLeveledUpMasteryIDs = new LinkedList<List<int>>();
            allLeveledUpMasteryIDs.AddLast(MasteryLogic.IncreaseMastery(57, test));
            allLeveledUpMasteryIDs.AddLast(MasteryLogic.IncreaseMastery(57, test));
            allLeveledUpMasteryIDs.AddLast(MasteryLogic.IncreaseMastery(57, test));
            allLeveledUpMasteryIDs.AddLast(MasteryLogic.IncreaseMastery(57, test));
            MasteryLogic.DecreaseMastery(allLeveledUpMasteryIDs.Last(), test);
            allLeveledUpMasteryIDs.RemoveLast();

            AttributeLogic.IncreaseAttribute(1, test, false);
            AttributeLogic.IncreaseAttribute(1, test, true);
            test.CharacterLevel = 2;
            AttributeLogic.IncreaseAttribute(1, test, false);
            AttributeLogic.IncreaseAttribute(1, test, false);
            AttributeLogic.IncreaseAttribute(1, test, true);
            AttributeLogic.DecreaseAttribute(1, test, false);
            AttributeLogic.DecreaseAttribute(1, test, true);

            CombatStatLogic.IncreaseCombatStatWithCCP(1, test);
            ResourceLogic.IncreaseResourceWithCCP(2, test);
        }
    }
}
