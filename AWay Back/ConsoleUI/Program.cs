using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameWorld;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Builder.Build(); // Build all of the list.
            BuildPlayer.BuildAPlayer();

            bool exit = false;

            string[] Weapons = { "EnergySword", "PlasmaBow", "ProtonPistol", "DecoyGrenade" };
            string[] Potions = { "HealthPotion", "StaminaPotion" };
            string[] Treasure = { "Credits", "Titanium", "Electronic Parts" };
            List<string> Items = new List<string>() { "Map", "Armor", "Plasma Arrows", "Proton Bullets" };
            List<Mobs> Mobs = new List<Mobs>() { new Mobs("Ghoul", "Ugly", "Bleed", "Fire", 100, "Undead"),
                                                    new GameWorld.Mobs("BrainEater","Ugly","Confusion","Pierce", 100, "Alien"),
                                                    new GameWorld.Mobs("FaceEater","Ugly","Poison", "Shock", 100, "Worm"),
                                                    new GameWorld.Mobs("MediumWorm", "Ugly","Trample", "Blast", 100, "Worm"),
                                                    new GameWorld.Mobs("Mimic", "Ugly","Dark", "Slash", 100, "copy")};

            DisplayCurrentRoom.CurrentRoom();


            do
            {
                Console.Write(StandardMessages.DisplayMenu());
                //Taking the user's choice and passing it through a switch statement. Using console.readline for the argument. 


                switch (Console.ReadLine())
                {
                    case "1":
                        //BuildPlayer.BuildAPlayer();
                        StandardMessages.CleaningCode();
                        //StandardMessages.DisplayCreatedPlayer();
                        break;

                    case "2":
                        //Issues showing rooms. Class looks correct and Array looks correct. 
                        StandardMessages.CleaningCode();
                        Console.WriteLine(StandardMessages.PromptForMovement());
                        GameAction.PlayerActions(Console.ReadLine(), Player._player);
                        StandardMessages.CleaningCode();
                        break;

                    case "3":
                        //Issues showing rooms. Class looks correct and Array looks correct. 
                        StandardMessages.CleaningCode();
                        Console.WriteLine(StandardMessages.PromptForAttack());
                        //Console.WriteLine(StandardMessages.DisplayCurrentRoom(Console.ReadLine(), Rooms, Rooms2, ref index));
                        //GameAction.AttackMobs(Console.ReadLine(), Rooms, ref index, Rooms2, Mobs, thisPlayer);
                        StandardMessages.CleaningCode();
                        break;

                    case "4":
                        //Exit the program --> Set the boolean variable to true and display goodbye message. 
                        Console.WriteLine(StandardMessages.DisplayGoodbye());
                        Console.ReadLine();
                        exit = true;
                        break;

                    default:
                        //Call number error message for incorrect menu choice. 
                        Console.WriteLine(StandardMessages.DisplayNumberError());
                        Console.ReadLine();
                        break;
                }


        } while (exit == false);
        }
    }
}
