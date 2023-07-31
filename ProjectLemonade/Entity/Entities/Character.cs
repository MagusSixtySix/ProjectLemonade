using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class Character : ICharacter
    {
        private string characterName;
        private int characterLevel;
        private int characterCreationPoints;
        private string characterReligion;
        private IPersonality characterPersonality;
        private int characterRace;
        private int characterClass;
        private int characterOrder;
        private List<ICharacterAttribute> characterAttributes;
        private List<IResource> characterResources;
        private List<ICombatStat> characterCombatStats;
        private List<int> characterMasteries;
        private List<int> characterBackgrounds;
        private List<IItem> characterItems;

        public Character(string characterName, int characterLevel, int characterCreationPoints, 
            string characterReligion, IPersonality characterPersonality, int characterRace,
            int characterClass, int characterOrder, List<ICharacterAttribute> characterAttributes,
            List<IResource> characterResources, List<ICombatStat> characterCombatStats,
            List<int> characterMasteries, List<int> characterBackgrounds, List<IItem> characterItems)
        {
            CharacterName = characterName;
            CharacterLevel = characterLevel;
            CharacterCreationPoints = characterCreationPoints;
            CharacterReligion = characterReligion;
            CharacterPersonality = characterPersonality;
            CharacterRace = characterRace;
            CharacterClass = characterClass;
            CharacterOrder = characterOrder;
            CharacterAttributes = characterAttributes;
            CharacterResources = characterResources;
            CharacterCombatStats = characterCombatStats;
            CharacterMasteries = characterMasteries;
            CharacterBackgrounds = characterBackgrounds;
            CharacterItems = characterItems;
        }

        public string CharacterName { get => characterName; set => characterName = value; }
        public int CharacterLevel { get => characterLevel; set => characterLevel = value; }
        public int CharacterCreationPoints { get => characterCreationPoints; set => characterCreationPoints = value; }
        public string CharacterReligion { get => characterReligion; set => characterReligion = value; }
        public IPersonality CharacterPersonality { get => characterPersonality; set => characterPersonality = value; }
        public int CharacterRace { get => characterRace; set => characterRace = value; }
        public int CharacterClass { get => characterClass; set => characterClass = value; }
        public int CharacterOrder { get => characterOrder; set => characterOrder = value; }
        public List<ICharacterAttribute> CharacterAttributes { get => characterAttributes; set => characterAttributes = value; }
        public List<IResource> CharacterResources { get => characterResources; set => characterResources = value; }
        public List<ICombatStat> CharacterCombatStats { get => characterCombatStats; set => characterCombatStats = value; }
        public List<int> CharacterMasteries { get => characterMasteries; set => characterMasteries = value; }
        public List<int> CharacterBackgrounds { get => characterBackgrounds; set => characterBackgrounds = value; }
        public List<IItem> CharacterItems { get => characterItems; set => characterItems = value; }
    }
}
