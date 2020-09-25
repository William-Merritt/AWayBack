﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameWorld
{
    public static class IDA
    {
        public static readonly List<Rooms> Room = new List<Rooms>(); // To hold the new rooms. List cannot be changed. Readonly
        public static readonly List<Mobs> Mob = new List<Mobs>();



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