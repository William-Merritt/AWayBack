using System.IO;
using System;

namespace GameWorld
{
    public static class BuildPlayer
    {
        public static void BuildAPlayer()
        {

            string correct = "valid";
            string password;
            string inputString;
            string returning;
            string name;
            string playerClass = "";
            string race = "";
            int hp = 0;
            bool check = false;

            Console.WriteLine(StandardMessages.ReturningPlayer());
            returning = Console.ReadLine();
            if (returning == "y")
            {
                Console.WriteLine("Welcome Back Player!!");
                Console.WriteLine("Enter your password");
                string returnpassword = Console.ReadLine();
                StreamReader readFile = File.OpenText(@"../../../ConsoleUI/bin/Debug/Player.txt");
                password = readFile.ReadLine();
                name = readFile.ReadLine();
                playerClass = readFile.ReadLine();
                race = readFile.ReadLine();
                readFile.Close();



                if (password == returnpassword)
                {
                    Player._player = new Player(name, playerClass, password, hp, race);
                }
                else
                {
                   
                    do
                    {
                        Console.WriteLine("Password does not match any on record. Make a new player based on the steps below.");
                        Console.WriteLine(StandardMessages.PromptForPassword());
                        inputString = Console.ReadLine();
                        password = PasswordCheck.CheckPassword(inputString);
                        if (password == correct)
                        {
                            Console.WriteLine("Password is valid\n");
                            check = true;
                        }
                        else
                        {
                            Console.WriteLine("Password is invalid. Try again.\n");
                        }
                    } while (check == false);



                    Console.WriteLine("What is your name: ");
                    Console.Write("---> ");
                    name = Console.ReadLine();

                    Console.WriteLine("Please select a class: Marksman/Swordsman/Trapper/Specialist");
                    Console.Write("---> ");
                    playerClass = Console.ReadLine();

                    Console.WriteLine("Please select a race: Human/Dwarf/Dracokin/Elf");
                    Console.Write("---> ");
                    race = Console.ReadLine();


                    if (race == "Human" || race == "1")
                    {
                        hp = 150;

                    }
                    else if (race == "Dwarf" || race == "2")
                    {
                        hp = 220;

                    }
                    else if (race == "Dracokin" || race == "3")
                    {
                        hp = 300;

                    }
                    else if (race == "Elf" || race == "4")
                    {
                        hp = 190;

                    }
                    else
                    {
                        hp = 130;
                    }

                    Player._player = new Player(name, playerClass, password, hp, race);

                    StreamWriter outputFile = File.CreateText(@"../../../ConsoleUI/bin/Debug/Player.txt");
                    try
                    {
                        outputFile.WriteLine(inputString);
                        outputFile.WriteLine(name);
                        outputFile.WriteLine(playerClass);
                        outputFile.WriteLine(race);
                        outputFile.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        Console.ReadLine();
                    }
                }
            }

            else {


                do
                {

                    Console.WriteLine(StandardMessages.PromptForPassword());
                    inputString = Console.ReadLine();
                    password = PasswordCheck.CheckPassword(inputString);
                    if (password == correct)
                    {
                        Console.WriteLine("Password is valid\n");
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Password is invalid. Try again.\n");
                    }
                } while (check == false);



                Console.WriteLine("What is your name: ");
                Console.Write("---> ");
                name = Console.ReadLine();

                Console.WriteLine("Please select a class: Marksman/Swordsman/Trapper/Specialist");
                Console.Write("---> ");
                playerClass = Console.ReadLine();

                Console.WriteLine("Please select a race: Human/Dwarf/Dracokin/Elf");
                Console.Write("---> ");
                race = Console.ReadLine();


                if (race == "Human" || race == "1")
                {
                    hp = 150;

                }
                else if (race == "Dwarf" || race == "2")
                {
                    hp = 220;

                }
                else if (race == "Dracokin" || race == "3")
                {
                    hp = 300;

                }
                else if (race == "Elf" || race == "4")
                {
                    hp = 190;

                }
                else
                {
                    hp = 130;
                }

                Player._player = new Player(name, playerClass, password, hp, race);

                StreamWriter outputFile = File.AppendText("Player.txt");
                try
                {
                    outputFile.WriteLine(inputString);
                    outputFile.WriteLine(name);
                    outputFile.WriteLine(playerClass);
                    outputFile.WriteLine(race);
                    outputFile.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadLine();
                }
            }
        }
        

           

        
    }
}
