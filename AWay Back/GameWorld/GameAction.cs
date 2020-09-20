﻿using System;
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

        public static void MoveEast(Rooms[] rooms2, ref int index)
        {
            if (index != rooms2.Length - 1)
            {
                index++;
                Console.WriteLine($"Now moving to ---> {rooms2[index].RoomName}");
            }
            else
            {
                Console.WriteLine("No More Rooms!");
            }
        }

        public static void MoveWest(Rooms[] rooms2, ref int index)
        {
            if (index > 0)
            {
                index--;
                Console.WriteLine($"Now returning to ---> {rooms2[index].RoomName}");
            }
            else
            {
                Console.WriteLine("No More Rooms!");
            }
        }

        public static void MovePlayer(string input, Rooms[] rooms, ref int index, Rooms[] rooms2)
        {

            string noun;
            string verb;


            input.Trim();

            string[] tokens = input.Split(null);

            noun = tokens[1];
            verb = tokens[0];

            if (verb == "move" && noun == "north")
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
            else if (verb == "move" && noun == "south")
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

            else if (verb == "move" && noun == "east")
            {
                if (index < rooms2.Length)//Creating an if statement to consider out of bounds error. 
                {
                    if (index != rooms2.Length - 1)
                    {
                        index++;
                        Console.WriteLine($"Now moving to ---> {rooms2[index].RoomName}");
                    }
                    else
                    {
                        Console.WriteLine("No More Rooms!");
                    }

                }
            }

            else if (verb == "move" && noun == "west")
            {
                if (index > 0)
                {
                    index--;
                    Console.WriteLine($"Now returning to ---> {rooms2[index].RoomName}");
                }
                else
                {
                    Console.WriteLine("No More Rooms!");
                }
            }
            else
            {
                Console.WriteLine(StandardMessages.DisplayNumberError());
            }

        }

        // Need to finish AttackMobs.
        // Last edit - 09/18/2020
        public static void AttackMobs(string input, Rooms[] rooms, ref int index, Rooms[] rooms2, List<Mobs> mobs, Player inputPlayer)
        {
            string noun;
            string verb;

            input.Trim();

            string[] tokens = input.Split(null);

            noun = tokens[1];
            verb = tokens[0];

            if (verb == "attack" && noun == "ghoul" && rooms[index].Exits == "ghoul")
            {

                Console.WriteLine($"Fighting --->{mobs[0].FirstName}--{mobs[0].LastName}\n" +
                              $"Boss Current HP is --> {mobs[0].Health}");

                Console.WriteLine(" ");

                Random rand = new Random();

                int combat = rand.Next(20) + 1;

                Console.WriteLine($"You hit the boss for {combat} points! ");
                Console.WriteLine(" ");

                mobs[0].Health -= combat;

                Console.WriteLine($"Boss Current HP is --> {mobs[0].Health}");
                Console.WriteLine(" ");

                Console.WriteLine($"Fighting --->{inputPlayer.FirstName}--{inputPlayer.LastName}\n" +
                               $"Boss Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");

                int combat2 = rand.Next(20) + 1;
                Console.WriteLine($"You were hit for {combat2} points! ");
                Console.WriteLine(" ");
                inputPlayer.Health -= combat2;

                Console.WriteLine($"Your Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");



            }
            else if (verb == "attack" && noun == "braineater" && rooms[index].Exits == "braineater")
            {

                Console.WriteLine($"Fighting --->{mobs[1].FirstName}--{mobs[1].LastName}\n" +
                              $"Boss Current HP is --> {mobs[1].Health}");

                Console.WriteLine(" ");

                Random rand = new Random();

                int combat = rand.Next(20) + 1;

                Console.WriteLine($"You hit the boss for {combat} points! ");
                Console.WriteLine(" ");

                mobs[1].Health -= combat;

                Console.WriteLine($"Boss Current HP is --> {mobs[1].Health}");
                Console.WriteLine(" ");

                Console.WriteLine($"Fighting --->{inputPlayer.FirstName}--{inputPlayer.LastName}\n" +
                               $"Boss Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");

                int combat2 = rand.Next(20) + 1;
                Console.WriteLine($"You were hit for {combat2} points! ");
                Console.WriteLine(" ");
                inputPlayer.Health -= combat2;

                Console.WriteLine($"Your Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");
            }

            else if (verb == "attack" && noun == "mediumworm" && rooms[index].Exits == "mediumworm")
            {

                Console.WriteLine($"Fighting --->{mobs[3].FirstName}--{mobs[3].LastName}\n" +
                              $"Boss Current HP is --> {mobs[3].Health}");

                Console.WriteLine(" ");

                Random rand = new Random();

                int combat = rand.Next(20) + 1;

                Console.WriteLine($"You hit the boss for {combat} points! ");
                Console.WriteLine(" ");

                mobs[3].Health -= combat;

                Console.WriteLine($"Boss Current HP is --> {mobs[3].Health}");
                Console.WriteLine(" ");

                Console.WriteLine($"Fighting --->{inputPlayer.FirstName}--{inputPlayer.LastName}\n" +
                               $"Boss Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");

                int combat2 = rand.Next(20) + 1;
                Console.WriteLine($"You were hit for {combat2} points! ");
                Console.WriteLine(" ");
                inputPlayer.Health -= combat2;

                Console.WriteLine($"Your Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");
            }

            else if (verb == "attack" && noun == "faceeater" && rooms[index].Exits == "faceeater")
            {

                Console.WriteLine($"Fighting --->{mobs[2].FirstName}--{mobs[2].LastName}\n" +
                              $"Boss Current HP is --> {mobs[2].Health}");

                Console.WriteLine(" ");

                Random rand = new Random();

                int combat = rand.Next(20) + 1;

                Console.WriteLine($"You hit the boss for {combat} points! ");
                Console.WriteLine(" ");

                mobs[2].Health -= combat;

                Console.WriteLine($"Boss Current HP is --> {mobs[2].Health}");
                Console.WriteLine(" ");

                Console.WriteLine($"Fighting --->{inputPlayer.FirstName}--{inputPlayer.LastName}\n" +
                               $"Boss Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");

                int combat2 = rand.Next(20) + 1;
                Console.WriteLine($"You were hit for {combat2} points! ");
                Console.WriteLine(" ");
                inputPlayer.Health -= combat2;

                Console.WriteLine($"Your Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");
            }

            else if (verb == "attack" && noun == "mimic" && rooms[index].Exits == "mimic")
            {

                Console.WriteLine($"Fighting --->{mobs[4].FirstName}--{mobs[4].LastName}\n" +
                              $"Boss Current HP is --> {mobs[4].Health}");

                Console.WriteLine(" ");

                Random rand = new Random();

                int combat = rand.Next(20) + 1;

                Console.WriteLine($"You hit the boss for {combat} points! ");
                Console.WriteLine(" ");

                mobs[4].Health -= combat;

                Console.WriteLine($"Boss Current HP is --> {mobs[4].Health}");
                Console.WriteLine(" ");

                Console.WriteLine($"Fighting --->{inputPlayer.FirstName}--{inputPlayer.LastName}\n" +
                               $"Boss Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");

                int combat2 = rand.Next(20) + 1;
                Console.WriteLine($"You were hit for {combat2} points! ");
                Console.WriteLine(" ");
                inputPlayer.Health -= combat2;

                Console.WriteLine($"Your Current HP is --> {inputPlayer.Health}");
                Console.WriteLine(" ");
            }

            else 
            {
                Console.WriteLine("No mobs in sight. You're currently safe...");
            }





        }
    }
}
