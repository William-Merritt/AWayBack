using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class LivingCreature
    {
        // Fields
        private int _health;
        private string _race;

        // Constructor
        public LivingCreature()
        {
            Health = 0;
            Race = "";
        }
        public LivingCreature(int health, string race)
        { 
            Health = health;
            Race = race;
        }

        // Properties
       
        public int Health { get; set; }

        public string Race { get; set; }
    }
}
