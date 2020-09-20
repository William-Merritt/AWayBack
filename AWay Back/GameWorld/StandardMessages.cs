using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class StandardMessages
    {
        public static string DisplayMenu()
        {
            return "1. Create Player\n2. Move Player\n3. Attack Enemy\n4. Exit Program\nPlease Enter A Choice: ";
        }

        public static string PromptForMovement() 
        {
            return "Which direction would you like to move in?\n" +
                "Ex. Please type move north/move west/move south/go east\n" +
                "Move Player ---> ";
        }

        public static string PromptForAttack() 
        {
            return "Would you like to attack?\n" +
                "Ex. attack ghoul/attack mimic/attack braineater/attack faceeater/attack mediumworm\n" +
                "Attack Mob ---> ";
        }

        public static string DisplayNumberError()
        {
            return "Error! Enter a 1/2/3/4";
        }

        public static string DisplayGoodbye()
        {
            return "Thanks for playing!";
        }

        public static string GetFirstName()
        {
            return "What is your character's first name?";
        }

        public static string GetLastName()
        {
            return "What is your character's last name?";
        }

        public static void CleaningCode()
        {
            Console.WriteLine(" ");
        }

        public static void DisplayCreatedPlayer(Player thisPlayer)
        {
            Console.WriteLine($"Player Name -->{thisPlayer.FirstName}\n" +
                $"Player Last Name --> {thisPlayer.LastName}\n" +
                $"Player Class --> {thisPlayer.PlayerClass}\n" +
                $"Player Race --> {thisPlayer.Race}\n" +
                $"Player Current Health --> {thisPlayer.Health}");
        }

        //public static string DisplayCurrentRoom(string input, Rooms[] room, Rooms[] rooms2, ref int index)
        //{
        //    string noun;
        //    string verb;

        //    input.Trim();
            
        //    string[] tokens = input.Split(null);

        //    noun = tokens[1];
        //    verb = tokens[0];

        //    if (verb == "move" && noun == "north" || noun == "south")
        //    {
        //        return $"Currently in ---> {room[index].RoomName}";
        //    }
        //    else if (verb == "move" && noun == "east" || noun == "west")
        //    {

        //        return $"You're currently at the ---> {rooms2[index].RoomName}";
        //    }
        //    else 
        //    {
        //        return $"Error! Not a valid direction. Ex. move north.";
        //    }
        //}

        public static string PromptForPassword()
        {
            return "Password Requirements: Length must be between 8 to 15 characters.\n" +
                    "Must Contain at least one Capital Letter\n" +
                    "Must Contain at least one Lowercase Letter\n" +
                    "Must Contain at least one Punctuation Mark\n" +
                    "Please create a password for the player: ";
        }
    }
}
