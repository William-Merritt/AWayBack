using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;

            do
            {

                Console.WriteLine(StandardMessages.DisplayMenu());


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
                        Console.WriteLine(StandardMessages.DisplayCurrentRoom(rooms, ref index));
                        GameAction.MoveNorth(rooms, ref index);
                        StandardMessages.CleaningCode();
                        break;

                    case "3":
                        //Issues showing rooms. Class looks correct and Array looks correct. 
                        StandardMessages.CleaningCode();
                        Console.WriteLine(StandardMessages.DisplayCurrentRoom(rooms, ref index));
                        GameAction.MoveSouth(rooms, ref index);
                        StandardMessages.CleaningCode();
                        break;

                    case "4":
                        //TODO figure out how to manipulate objects more. Selecting a random mob to appear.
                        GameAction.Attack(mobs[0]);
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
