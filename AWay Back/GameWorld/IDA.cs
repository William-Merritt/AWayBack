using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameWorld
{
    public static class IDA
    {
        public static readonly List<Rooms> Room = new List<Rooms>(); // To hold the new rooms. List cannot be changed. Readonly
        public static readonly List<Mobs> Mob = new List<Mobs>();
        public static readonly List<Items> Item = new List<Items>();
        public static readonly List<Potions> Potion = new List<Potions>();
        public static readonly List<Weapons> Weapon = new List<Weapons>();
        public static readonly List<Treasure> Treasure = new List<Treasure>();



        public static Items ItemByID(int id) 
        {
            return Item.SingleOrDefault(x => x.ID == id);
        }

        public static Items ItemByName(string name) 
        {
            return Item.SingleOrDefault(x => x.itemName == name);
        }

        public static Rooms FindID(int id)
        {
            return Room.SingleOrDefault(x => x.ID == id);
        }

        public static Mobs FindMobID(int id) 
        {
            return Mob.SingleOrDefault(x => x.ID == id);
        }

        public static Mobs FindMobName(string name) 
        {
            return Mob.SingleOrDefault(x => x.Name == name);
        }
    }

}
