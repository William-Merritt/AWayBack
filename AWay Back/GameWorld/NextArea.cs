using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public static class NextArea
    {
        public static void MoveTo(string noun)
        {
            Movement.PlayerMovement(noun);
            DisplayCurrentRoom.CurrentRoom();
            if (Movement.moveHere == false)
            {
                Console.WriteLine("You can not go " + noun);
            }
        }
    }
}
