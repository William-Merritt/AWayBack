using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class LivingCreature
    {
        // Fields

        // Constructor
        public LivingCreature()
        {
            FirstName = "";
            LastName = "";
            Health = 0;
            Race = "";
        }
        public LivingCreature(string firstName, string lastName, int health, string race)
        {
            FirstName = firstName;
            LastName = lastName;
            Health = health;
            Race = race;
        }

        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Health { get; set; }

        public string Race { get; set; }
    }
}
