using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Model.Entities
{
    internal class BackgroundList
    {
        private List<IBackground> backgrounds;

        public List<IBackground> Backgrounds { get => backgrounds; set => backgrounds = value; }
    }
}
