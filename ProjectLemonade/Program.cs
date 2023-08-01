using ProjectLemonade.Entity.Entities;
using ProjectLemonade.Interfaces;
using ProjectLemonade.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Character testSubject = new Character("TestSubject", 1, 43, "TestReligion", new Personality(new Trait("Chaotic"), new Trait("Good")), 1, 3, 2,
                new List<ICharacterAttribute>{new CharacterAttribute("Strength", 20, 18, 0, 0, 0), new CharacterAttribute("Dexterity", 20, 16, 0, 0, 0),
                new CharacterAttribute("Intelligence", 18, 14, 0, 0, 0) }, new List<IResource>{new Resource("HealthPoints", 16, 0), new Resource("PainPoints"
                , 34, 24), new Resource("ManaPoints", 0, 8) }, new List<ICombatStat> {new CombatStat("Initiative", 34, 5), new CombatStat("Attack", 89, 43),
                new CombatStat("Defense", 125, 14), new CombatStat("Accuracy", 25, 14)}, new List<int> { 1, 2, 3, 4, 5, 6, }, new List<int> { 2, 5, 6 }, 
                new List<IItem> { new Item("Sword", ItemType.weapon, 32.4, 2.0, 3.45)});

            JsonFileHandler.SaveCharacterToJson(testSubject);*/

            Character test = (Character)JsonFileHandler.ReadJsonToObject(@JsonFileHandler.GetCharacterFileName("TestSubject"));
        }
    }
}
