using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public static class DisplayCurrentRoom
    {
        public static void CurrentRoom()
        { 
            Console.WriteLine("Currently in : {0}", Player.CurrentRoom.RoomName);

            if (Player.CurrentRoom.Description != "")
            {
                Console.WriteLine(Player.CurrentRoom.Description);
            }

            string exit = "\n[You may go to these locations: ";

            List<string> exits = new List<string>();
            if (Player.CurrentRoom.ExitNorth != -1)
                exits.Add("north");
            if (Player.CurrentRoom.ExitEast != -1)
                exits.Add("east");
            if (Player.CurrentRoom.ExitWest != -1)
                exits.Add("west");
            if (Player.CurrentRoom.ExitSouth != -1)
                exits.Add("south");
            if (exits.Count == 1)
                exit += exits[0] + " ";
            else
            {
                for (int i = 0; i < exits.Count; i++)
                {
                    exit += exits[i];
                    if (i < exits.Count - 1)
                        exit += ", ";
                }
            }

            Console.WriteLine(exit + "]");

            if (Player.CurrentRoom.RoomMobs != null) 
            {
                foreach (Mobs mob in Player.CurrentRoom.RoomMobs) 
                {
                    if (mob.ID != 5)
                    {
                        Player.CurrentMob = mob;

                        Console.WriteLine($"You see a {mob.Name}. Procced with caution");
                    }
                    else 
                    {
                        Player.CurrentMob = mob;

                        Console.WriteLine($"You see a {mob.Name}. You may want to run.");
                    }
                }
            }
        }


    }
}
