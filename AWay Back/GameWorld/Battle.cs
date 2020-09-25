using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameWorld
{
    public static class Battle
    {
        public static void CommenceCombat(string noun, Player player)
        {
            if (Player.CurrentRoom.RoomMobs == null)
            {
                Console.WriteLine("Nothing to attack. You're safe.");
            }
            else
            {
                Mobs foundMob;
                if (LookForMob(noun, out foundMob))
                {
                    Attack(foundMob, player);
                }
            }

        }

        public static bool LookForMob(string mobName, out Mobs foundMob)
        {
            foreach (Mobs mob in Player.CurrentRoom.RoomMobs)
            {
                if (mob.Name.Equals(mobName))
                {
                    foundMob = mob;
                    return true;
                }
            }
            foundMob = null;
            return false;
        }

        public static void Attack(Mobs newMob, Player player) 
        {
            Console.WriteLine($"Fighting --->{newMob.Name}\n" +
                                         $"Boss Current HP is --> {newMob.Health}");

            Console.WriteLine(" ");

            Random rand = new Random();

            int combat = rand.Next(20) + 1;

            Console.WriteLine($"You hit the boss for {combat} points! ");
            Console.WriteLine(" ");

            newMob.Health -= combat;

            Console.WriteLine($"Boss Current HP is --> {newMob.Health}");
            Console.WriteLine(" ");

            Console.WriteLine($"Fighting --->{player.Name}\n" +
                           $"Boss Current HP is --> {player.Health}");
            Console.WriteLine(" ");

            int combat2 = rand.Next(20) + 1;
            Console.WriteLine($"You were hit for {combat2} points! ");
            Console.WriteLine(" ");
            player.Health -= combat2;

            Console.WriteLine($"Your Current HP is --> {player.Health}");
            Console.WriteLine(" ");
            Console.ReadLine();
        }

    }
}
