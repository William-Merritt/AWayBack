using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Mobs : LivingCreature
    {
        //  Fields
        //private string _firstName;
        //private string _lastName;
        private string _mobType;
        private string _mobWeakness;


        // Constructors
        public Mobs()
        {
            FirstName = "";
            LastName = "";
            MobType = "";
            MobWeakness = "";
            Health = 0;
            Race = "";
        }

        public Mobs(string firstName, string lastName, string mobType, string mobWeakness, int health, string race) :
                    base(firstName, lastName, health, race)
        {
            MobType = mobType;
            MobWeakness = mobWeakness;
        }

        // Properties

        public string MobType
        {
            get
            {
                return _mobType;
            }
            set
            {
                _mobType = value;
            }
        }

        public string MobWeakness
        {
            get
            {
                return _mobWeakness;
            }
            set
            {
                _mobWeakness = value;
            }
        }


    }
}
