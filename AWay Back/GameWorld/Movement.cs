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

        public static void PlayerMovement(string input) 
        {

            string noun;
            string verb;


            input.Trim();

            string[] tokens = input.Split(null);

            noun = tokens[1];
            verb = tokens[0];

            if(verb == "go" && noun == "north") 
            {
                if (Player.CurrentRoom.ExitNorth != -1)
                {
                    MovePlayer(IDA.CurrentRoom[Player.CurrentRoom.ExitNorth]);
                }
                else 
                {
                    moveHere = false;
                }
            }
            if (verb == "go" && noun == "east")
            {
                if (Player.CurrentRoom.ExitEast != -1)
                {
                    MovePlayer(IDA.CurrentRoom[Player.CurrentRoom.ExitEast]);
                }
                else
                {
                    moveHere = false;
                }
            }
            if (verb == "go" && noun == "south")
            {
                if (Player.CurrentRoom.ExitSouth != -1)
                {
                    MovePlayer(IDA.CurrentRoom[Player.CurrentRoom.ExitSouth]);
                }
                else
                {
                    moveHere = false;
                }
            }
            if (verb == "go" && noun == "west")
            {
                if (Player.CurrentRoom.ExitWest != -1)
                {
                    MovePlayer(IDA.CurrentRoom[Player.CurrentRoom.ExitWest]);
                }
                else
                {
                    moveHere = false;
                }
            }
        }
    }
}
