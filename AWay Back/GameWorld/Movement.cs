using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public static class Movement
    {

        public static bool moveHere = true;

        public static void NewRoom(Rooms currentLocation) 
        {
            Player.CurrentRoom = currentLocation;
        }

        public static void MovePlayer(Rooms currentLocation) 
        {
            NewRoom(currentLocation);
        }

        public static void MoveToStart() 
        {
            MovePlayer(IDA.Room[0]);
        }

        public static void PlayerMovement(string noun) 
        {

            if(noun == "north") 
            {
                if (Player.CurrentRoom.ExitNorth != -1)
                {
                    MovePlayer(IDA.Room[Player.CurrentRoom.ExitNorth]);
                    DisplayCurrentRoom.CurrentRoom();
                    Console.ReadLine();
                }
                else 
                {
                    moveHere = false;
                }
            }
            if (noun == "east")
            {
                if (Player.CurrentRoom.ExitEast != -1)
                {
                    MovePlayer(IDA.Room[Player.CurrentRoom.ExitEast]);
                    DisplayCurrentRoom.CurrentRoom();
                    Console.ReadLine();
                }
                else
                {
                    moveHere = false;
                }
            }
            if (noun == "south")
            {
                if (Player.CurrentRoom.ExitSouth != -1)
                {
                    MovePlayer(IDA.Room[Player.CurrentRoom.ExitSouth]);
                    DisplayCurrentRoom.CurrentRoom();
                    Console.ReadLine();
                }
                else
                {
                    moveHere = false;
                }
            }
            if (noun == "west")
            {
                if (Player.CurrentRoom.ExitWest != -1)
                {
                    MovePlayer(IDA.Room[Player.CurrentRoom.ExitWest]);
                    DisplayCurrentRoom.CurrentRoom();
                    Console.ReadLine();
                }
                else
                {
                    moveHere = false;
                }
            }
        }
    }
}
