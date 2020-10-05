using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace GameWorld
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
                    NewMob();
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
                        foreach (Mobs mob in IDA.Mob.ToList())
                        {
                            if (mob.ID == id)
                            {
                                Console.WriteLine("Error. A mob already contains that ID.");
                            }
                        }

                        Console.WriteLine("What is the Mob ID: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("What is the Mob Name: ");
                        name = Console.ReadLine();

                        Console.WriteLine("What is the Mob Info: ");
                        mobInfo = Console.ReadLine();

                        Console.WriteLine("What is the Mob Damage Type: ");
                        mobDmgType = Console.ReadLine();

                        Console.WriteLine("What is the Mob's Weakness: ");
                        mobWeakness = Console.ReadLine();

                        Console.WriteLine("Amount of HP: ");
                        health = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("What is the race of this Mob: ");
                        race = Console.ReadLine();

                        IDA.Mob.Add(new Mobs(id, name, mobInfo, mobDmgType, mobWeakness, health, race));

                        if (File.Exists(@"../../../GameWorld/TextFiles/Mobs.txt")) 
                        {
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", "" + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", id.ToString() + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", name + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", mobInfo + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", mobDmgType + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", mobWeakness + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", health.ToString() + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", race);

                        }
                        done = true;
                    }
                }
            }
        }
        public static void NewRoom() 
        {
            
        }
    }
}
