using ProjectLemonade.Interfaces;
using ProjectLemonade.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Service
{
    public static class ResourceLogic
    {
        public static void PopulateResources(ICharacter character)
        {
            List<IResource> resources = JsonFileHandler.GetListFromFile<IResource>("resources");

            character.CharacterResources = new List<IResource>();

            foreach (var item in resources)
            {
                character.CharacterResources.Add(item);
            }
        }

        public static void UpdateBaseValueOfResources(ICharacter character)
        {
            ICharacterAttribute constitution = character.CharacterAttributes.Find(x => x.Attribute.ID == 6);
            ICharacterAttribute stamina = character.CharacterAttributes.Find(x => x.Attribute.ID == 5);
            ICharacterAttribute willpower = character.CharacterAttributes.Find(x => x.Attribute.ID == 9);
            ICharacterAttribute intelligence = character.CharacterAttributes.Find(x => x.Attribute.ID == 8);

            foreach (var item in character.CharacterResources)
            {
                switch (item.ID)
                {
                    case 1: item.BaseValue = constitution.GetCurrentValue(); break;
                    case 2: item.BaseValue = stamina.GetCurrentValue() + willpower.GetCurrentValue(); break;
                    case 3: item.BaseValue = intelligence.GetCurrentValue(); break;
                    case 4: item.BaseValue = intelligence.GetCurrentValue(); break;
                    case 5: break;
                }
            }
        }

        public static bool IncreaseResourceWithCCP(int resourceID, ICharacter character)
        {
            IResource resource = character.CharacterResources.Find(x => x.ID == resourceID);
            int ccp = character.CharacterCreationPoints;

            switch (resourceID)
            {
                case 1: return false;
                case 2:
                    if (ccp >= 1)
                    {
                        resource.ValueFromCCP += 1;
                        return true;
                    }
                    else return false;
                case 3:
                    if (ccp >= 2)
                    {
                        resource.ValueFromCCP += 1;
                        return true;
                    }
                    else return false;
                case 4:
                    if (ccp >= 3)
                    {
                        resource.ValueFromCCP += 1;
                        return true;
                    }
                    else return false;
                case 5:
                    if (ccp >= 3)
                    {
                        resource.ValueFromCCP += 1;
                        return true;
                    }
                    else return false;
            }
            return false;
        }
        public static bool DecreaseResourceWithCCP(int resourceID, ICharacter character)
        {
            IResource resource = character.CharacterResources.Find(x => x.ID == resourceID);
            int ccp = character.CharacterCreationPoints;

            if (resource.ValueFromCCP == 0)
            {
                return false;
            }

            switch (resourceID)
            {
                case 1: return false;
                case 2: resource.ValueFromCCP -= 1; ccp += 1; return true;
                case 3: resource.ValueFromCCP -= 1; ccp += 2; return true;
                case 4: resource.ValueFromCCP -= 1; ccp += 3; return true;
                case 5: resource.ValueFromCCP -= 1; ccp += 3; return true;
            }
            return false;
        }
    }
}
