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
            ReadJson reader = new ReadJson();
            List<ICharacter> characters = reader.ReadCharacters(@"../../../test.json");
        }
    }
}
