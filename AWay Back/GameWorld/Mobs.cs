using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Mobs : LivingCreatures
    {
        //Fields

        private string _description;
        private string _attributes;



        //constructors

        //custom
        public Mobs(int health, string name, string description, string attributes) :
            base(health, name)
        {

            Description = description;

            Attributes = attributes;

        }
        //fullproperties


        public string Description { get; set; }

        public string Attributes { get; set; }


    }
}
