using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Interfaces
{
    public interface ICharacter
    {
        string CharacterName { get; set; }
        int CharacterLevel { get; set; }
        int CharacterCreationPoints { get; set; }  
        string CharacterReligion { get; set; }
        IPersonality CharacterPersonality { get; set; }
        int CharacterRace { get; set; }
        int CharacterClass { get; set; }
        int CharacterOrder { get; set; }
        List<ICharacterAttribute> CharacterAttributes { get; set; }
        List<IResource> CharacterResources { get; set; }
        List<ICombatStat> CharacterCombatStats { get; set; }
        List<int> CharacterMasteries { get; set; }
        List<int> CharacterBackgrounds { get; set; }
        List<IItem> CharacterItems { get; set; }
    }
}
