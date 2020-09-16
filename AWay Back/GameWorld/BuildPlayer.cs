﻿using System;

namespace GameWorld
{
    public class BuildPlayer
    {
        public static void BuildAPlayer(Player inputPlayer)
        {

            Console.WriteLine("Please create a password for your player");
            Console.Write("---> ");
            inputPlayer.Password = Console.ReadLine();

            Console.WriteLine("What is the first name of your player?");
            Console.Write("---> ");
            inputPlayer.FirstName = Console.ReadLine();

            Console.WriteLine("What is the last name of your player?");
            Console.Write("---> ");
            inputPlayer.LastName = Console.ReadLine();

            Console.WriteLine("Please select a class: Marksman/Swordsman/Trapper/Specialist");
            Console.Write("---> ");
            inputPlayer.PlayerClass = Console.ReadLine();

            Console.WriteLine("Please select a race: Human/Dwarf/Dracokin/Elf");
            Console.Write("---> ");
            inputPlayer.Race = Console.ReadLine();

            if (inputPlayer.Race == "Human" || inputPlayer.Race == "1")
            {
                inputPlayer.Health = 150;
            }
            else if (inputPlayer.Race == "Dwarf" || inputPlayer.Race == "2")
            {
                inputPlayer.Health = 220;
            }
            else if (inputPlayer.Race == "Dracokin" || inputPlayer.Race == "3")
            {
                inputPlayer.Health = 300;
            }
            else if (inputPlayer.Race == "Elf" || inputPlayer.Race == "4")
            {
                inputPlayer.Health = 190;
            }
        }
    }
}
