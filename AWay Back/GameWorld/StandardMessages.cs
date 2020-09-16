﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class StandardMessages
    {
        public static string DisplayMenu()
        {
            return "1. Create Player\n2. Move North\n3. Move South\n4. Attack Enemy\n5. Exit program\nPlease Enter A Choice:";
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

        public static string DisplayCurrentRoom(Rooms[] room, ref int index)
        {
            return $"You're currently at the ---> {room[index].RoomName}";
        }

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
