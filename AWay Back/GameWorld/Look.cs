using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameWorld
{
    public static class Look
    {
        public static void Looking(string noun) 
        {
            lookForVerb(noun);
        }

        public static void Looking() 
        {
            DisplayCurrentRoom.CurrentRoom();
        }

        public static void lookForVerb(string noun) 
        {
            Mobs lookForMob = IDA.FindMobName(noun);

            if (lookForMob != null) 
            {
                foreach (Mobs mob in Player.CurrentRoom.RoomMobs.ToList()) 
                {
                    if (mob.Name == lookForMob.Name) 
                    {
                        MobFound(mob);
                    }
                }
            }
        }

        public static string MobFound(Mobs lookForMob) 
        {
            return $"Name: {lookForMob.Name}\n" +
                $"Health: {lookForMob.Health}";
        }
    }
}
