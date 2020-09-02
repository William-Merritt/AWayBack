using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class LivingCreatures
    {
        private int _health;
        private string _name;

        public LivingCreatures()
        {
            Health = 0;

            Name = " ";

        }

        public LivingCreatures(int health, string name)
        {
            Health = health;
            Name = name;
        }

        public int Health { get; set; }

        public string Name { get; set; }
    }
}
