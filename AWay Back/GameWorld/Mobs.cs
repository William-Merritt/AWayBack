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
        private int _id;                                        // Will hold the id of the mob
        private string _name;
        private string _mobInfo;
        private string _mobDmgType;                            // Will hold the damage type of the mob
        private string _mobWeakness;                        // Will hold the weakness of the mob


        // Constructors
        public Mobs()
        {
            Name = "";
            MobInfo = "";
            MobDmgType = "";
            MobWeakness = "";
            Health = 0;
            Race = "";
        }

        public Mobs(int id, string name, string mobInfo, string mobDmgType, string mobWeakness, int health, string race) :
                    base(health, race)
        {
            ID = id;
            Name = name;
            MobInfo = mobInfo;
            MobDmgType = mobDmgType;
            MobWeakness = mobWeakness;
        }

        // Properties

        public string Name 
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }

        public string MobDmgType
        {
            get
            {
                return _mobDmgType;
            }
            set
            {
                _mobDmgType = value;
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

        public int ID 
        {
            get 
            {
                return _id;
            }
            set 
            {
                _id = value;
            }
        }

        public string MobInfo 
        {
            get 
            {
                return _mobInfo;
            }
            set 
            {
                _mobInfo = value;
            }
        }


        // Creating a mob object to be used to interact with player object. 
        public Mobs(Mobs newMob) : base(newMob.Health, newMob.Race) 
        {
            ID = newMob.ID;
            Name = newMob.Name;
            MobInfo = newMob.MobInfo;
            MobDmgType = newMob.MobDmgType;
            MobWeakness = newMob.MobWeakness;
            Health = newMob.Health;
            Race = newMob.Race;
        }

    }
}
