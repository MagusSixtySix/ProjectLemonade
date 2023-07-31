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
        IRace CharacterRace { get; set; }
        IPlayerClass CharacterClass { get; set; }
        IOrder CharacterOrder { get; set; }
        List<IAttribute> CharacterAttributes { get; set; }
        List<IResource> CharacterResources { get; set; }
        List<ICombatStat> CharacterCombatStats { get; set; }
        List<IMastery> CharacterMasteries { get; set; }
        List<IBackground> CharacterBackgrounds { get; set; }
        List<IItem> CharacterItems { get; set; }
    }
}
