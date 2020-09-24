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
            string name;
            string playerClass = "";
            string race = "";
            int hp = 0;
            bool check = false;

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
        }
    }
}
