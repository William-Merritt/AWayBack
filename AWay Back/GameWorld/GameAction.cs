using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class GameAction
    {
        /**
       * Creating the Second iteration of the Text Adventure Project
       */

        public static void MoveNorth(Rooms[] rooms, ref int index)
        {
            if (index < rooms.Length)//Creating an if statement to consider out of bounds error. 
            {
                if (index != rooms.Length - 1)
                {
                    index++;
                    Console.WriteLine($"Now moving to ---> {rooms[index].RoomName}");
                }
                else
                {
                    Console.WriteLine("No More Rooms!");
                }

            }

        }

        public static void MoveSouth(Rooms[] rooms, ref int index)
        {
            //Move through the array in reverse and display a previous room each time called.
            if (index > 0)
            {
                index--;
                Console.WriteLine($"Now returning to ---> {rooms[index].RoomName}");
            }
            else
            {
                Console.WriteLine("No More Rooms!");
            }

        }

        public static int Attack(Mobs inputMob)
        {

            Console.WriteLine($"Fighting --->{inputMob.FirstName}--{inputMob.LastName}\n" +
                              $"Boss Current HP is --> {inputMob.Health}");

            Console.WriteLine(" ");

            Random rand = new Random();

            int combat = rand.Next(20) + 1;

            Console.WriteLine($"You hit the boss for {combat} points! ");
            Console.WriteLine(" ");

            inputMob.Health -= combat;

            Console.WriteLine($"Boss Current HP is --> {inputMob.Health}");
            Console.WriteLine(" ");

            return inputMob.Health;

        }

        public static int AttackPlayer(Player inputPlayer)
        {
            Console.WriteLine($"Fighting --->{inputPlayer.FirstName}--{inputPlayer.LastName}\n" +
                              $"Boss Current HP is --> {inputPlayer.Health}");
            Console.WriteLine(" ");

            Random rand = new Random();
            int combat = rand.Next(20) + 1;
            Console.WriteLine($"You were hit for {combat} points! ");
            Console.WriteLine(" ");
            inputPlayer.Health -= combat;

            Console.WriteLine($"Your Current HP is --> {inputPlayer.Health}");
            Console.WriteLine(" ");

            return inputPlayer.Health;

        }

    }
}
