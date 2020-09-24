using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class LivingCreature
    {
        // Fields
        private string _name;
        private int _health;
        private string _race;

        // Constructor
        public LivingCreature()
        {
            Name = "";
            Health = 0;
            Race = "";
        }
        public LivingCreature(string name, int health, string race)
        {
            Name = name;
            Health = health;
            Race = race;
        }

        // Properties
       
        public int Health { get; set; }

        public string Race { get; set; }

        public string Name { get; set; }
    }
}
