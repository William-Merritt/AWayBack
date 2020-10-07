using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class GameAction
    {

        public static void PlayerActions(string input, Player _player) 
        {
            string[] actions = input.Split(null);
            string verb = actions[0].ToLower();
            string noun;
            if (actions.Length != 1)
            {
                noun = actions[1];
            }
            else 
            {
                noun = "";
            }

            if (_player.Race != "")
            {
                CompleteActions(verb, noun);
            }
            else 
            {
                Console.WriteLine(StandardMessages.DisplayNumberError());
            }
        }

        public static void CompleteActions(string verb, string noun) 
        {
            if (verb == "go")
            {
                Movement.PlayerMovement(noun);
            }
            else if (verb == "attack")
            {
                Battle.CommenceCombat(noun, Player._player);
            }
            else if (verb == "admin")
            {
                Create.PromptForCreation();
            }
            else 
            {
                Console.WriteLine(StandardMessages.DisplayNumberError());
            }
        }

    }
}
