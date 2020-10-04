using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld.AdminCenter
{
    public class Create
    {
        public static void PromptForCreation() 
        {
            string inputString;                         //Will hold all user input

            Console.Write("What are you making?");
            Console.WriteLine("Mob, Room, Weapon, Treasure, Item, or Potions:  ");
            inputString = Console.ReadLine();

            switch (inputString.ToLower()) 
            {
                case "mob":
                    break;

                case "room":
                    break;

                case "weapon":
                    break;

                case "treasure":
                    break;

                case "item":
                    break;

                case "potions":
                    break;

                default:
                    break;
            }
        }

        public static void NewMob() 
        {
            string inputString;                     //To hold all of the user input
            int id;
            string name;
            string mobInfo;
            string mobDmgType;
            string mobWeakness;
            int health;
            string race;
            bool done = false;

            while (done == false) 
            {
                Console.WriteLine("What is the ID for the mob?");
                Console.Write("1 - 100");
                inputString = Console.ReadLine();

                if (inputString != null) 
                {
                    id = Convert.ToInt32(inputString);
                    if (id > 1 && id <= 100) 
                    {
                        //foreach (Mobs mob in IDA.Mob.ToList())
                        //{
                        //    if (mob.ID == id) 
                        //    {
                        //        Console.WriteLine("Error. A mob already contains that ID.");
                        //    }
                        //}
                    }
                }
            }
        }
    }
}
