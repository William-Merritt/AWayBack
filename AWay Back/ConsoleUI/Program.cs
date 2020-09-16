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

            bool exit = false;
            int index = 0;

                // Creating the player.
                Player thisPlayer = new Player();

                Rooms[] Rooms = { new Rooms("PlanentSurface","", ""),
                                  new Rooms("Cave Entrance", "", ""),
                                  new Rooms("StarCraftBack", "", ""),
                                  new Rooms("StarCraftMiddle", "", ""),
                                  new Rooms("StarCraftFront", "", "")};
            
                string[] Weapons = { "EnergySword", "PlasmaBow", "ProtonPistol", "DecoyGrenade" };
                string[] Potions = { "HealthPotion", "StaminaPotion" };
                string[] Treasure = { "Credits", "Titanium", "Electronic Parts" };
                List<string> Items = new List<string>() { "Map", "Armor", "Plasma Arrows", "Proton Bullets" };
                List<Mobs> Mobs = new List<Mobs>() { new Mobs("Ghoul", "Ugly", "Bleed", "Fire", 100, "Undead"),
                                                     new GameWorld.Mobs("BrainEater","Ugly","Confusion","Pierce", 100, "Alien"),
                                                     new GameWorld.Mobs("FaceEater","Ugly","Poison", "Shock", 100, "Worm"),
                                                     new GameWorld.Mobs("MediumWorm", "Ugly","Trample", "Blast", 100, "Worm"),
                                                     new GameWorld.Mobs("Mimic", "Ugly","Dark", "Slash", 100, "copy")};

                do
                {
                    Console.Write(StandardMessages.DisplayMenu());
                    //Taking the user's choice and passing it through a switch statement. Using console.readline for the argument. 
                    switch (Console.ReadLine())
                    {
                        case "1":
                            BuildPlayer.BuildAPlayer(thisPlayer);
                            StandardMessages.CleaningCode();
                            StandardMessages.DisplayCreatedPlayer(thisPlayer);
                            break;

                        case "2":
                            //Issues showing rooms. Class looks correct and Array looks correct. 
                            StandardMessages.CleaningCode();
                            Console.WriteLine(StandardMessages.DisplayCurrentRoom(Rooms, ref index));
                            GameAction.MoveNorth(Rooms, ref index);
                            StandardMessages.CleaningCode();
                            break;

                        case "3":
                            //Issues showing rooms. Class looks correct and Array looks correct. 
                            StandardMessages.CleaningCode();
                            Console.WriteLine(StandardMessages.DisplayCurrentRoom(Rooms, ref index));
                            GameAction.MoveSouth(Rooms, ref index);
                            StandardMessages.CleaningCode();
                            break;

                        case "4":
                            //TODO figure out how to manipulate objects more. Selecting a random mob to appear.
                            GameAction.Attack(Mobs[0]);
                            StandardMessages.CleaningCode();
                            break;

                        case "5":
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
