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
                        break;

                    case "3":
                        //Issues showing rooms. Class looks correct and Array looks correct. 
                        StandardMessages.CleaningCode();
                        Console.WriteLine(StandardMessages.PromptForAttack());
                        GameAction.PlayerActions(Console.ReadLine(), Player._player);
                        Console.ReadLine();
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
