﻿using ProjectLemonade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLemonade.Entity.Entities
{
    internal class PlayerClass : IPlayerClass
    {
        private string name;
        private List<int> orders;
        private int iD;

        public PlayerClass(string name, List<int> orders, int iD) 
        {
            Name = name;
            Orders = orders;
            ID = iD;
        }

        public string Name { get => name; set => name = value; }
        public List<int> Orders { get => orders; set => orders = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
