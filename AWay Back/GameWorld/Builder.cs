using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GameWorld
{
    public static class Builder
    {
        private static string[] FindNextLine(StreamReader readFile) // TO be used later for monsters.
        {
            string[] lines = readFile.ReadLine().Split(' ');
            return lines;
        }

        public static void Build()
        {
            using (StreamReader readFile = File.OpenText(@"../../../GameWorld/TextFiles/Rooms.txt"))
            {
                while (!readFile.EndOfStream)
                {
                    int id = int.Parse(readFile.ReadLine());
                    string roomName = readFile.ReadLine();
                    string roomDescription = readFile.ReadLine();
                    int exitN = int.Parse(readFile.ReadLine());
                    int exitE = int.Parse(readFile.ReadLine());
                    int exitW = int.Parse(readFile.ReadLine());
                    int exitS = int.Parse(readFile.ReadLine());
                    int mobId = int.Parse(readFile.ReadLine());

                    IDA.Room.Add(new Rooms(id, roomName, roomDescription, exitN, exitE, exitW, exitS, mobId));
                }
            }

            using (StreamReader readFile = File.OpenText(@"../../../GameWorld/TextFiles/Mobs.txt"))
            {
                while (!readFile.EndOfStream)
                {
                    int id = int.Parse(readFile.ReadLine());
                    string name = readFile.ReadLine();
                    string mobInfo = readFile.ReadLine();
                    string mobDmgType = readFile.ReadLine();
                    string mobWeakness = readFile.ReadLine();
                    int health = int.Parse(readFile.ReadLine());
                    string mobRace = readFile.ReadLine();

                    IDA.Mob.Add(new Mobs(id, name, mobInfo, mobDmgType, mobWeakness, health, mobRace));
                }
            }

            using (StreamReader readFile = File.OpenText(@"../../../GameWorld/TextFiles/Items.txt"))
            {
                while (!readFile.EndOfStream)
                {
                    int id = int.Parse(readFile.ReadLine());
                    string itemname = readFile.ReadLine();
                    string itemdescription = readFile.ReadLine();
                    string size = readFile.ReadLine();
                    string quantity = readFile.ReadLine();
                    int price = int.Parse(readFile.ReadLine());

                    IDA.Item.Add(new Items(id,itemname, itemdescription, size, quantity, price));

                }
            }

            using (StreamReader readFile = File.OpenText(@"../../../GameWorld/TextFiles/Potions.txt"))
            {
                while (!readFile.EndOfStream)
                {
                    int id = int.Parse(readFile.ReadLine());
                    string itemname = readFile.ReadLine();
                    string itemdescription = readFile.ReadLine();
                    string healingvalue = readFile.ReadLine();
                    string quantity = readFile.ReadLine();
                    int price = int.Parse(readFile.ReadLine());

                    IDA.Potion.Add(new Potions(id, itemname, itemdescription, healingvalue, quantity, price));
                }
            }

            using (StreamReader readFile = File.OpenText(@"../../../GameWorld/TextFiles/Weapons.txt"))
            {
                while (!readFile.EndOfStream)
                {
                    int id = int.Parse(readFile.ReadLine());
                    string itemname = readFile.ReadLine();
                    string itemdescription = readFile.ReadLine();
                    string size = readFile.ReadLine();
                    string damage = readFile.ReadLine();
                    int price = int.Parse(readFile.ReadLine());

                    IDA.Weapon.Add(new Weapons(id,itemname, itemdescription, size, damage, price));
                }
            }

            using (StreamReader readFile = File.OpenText(@"../../../GameWorld/TextFiles/Treasure.txt"))
            {
                while (!readFile.EndOfStream)
                {
                    int id = int.Parse(readFile.ReadLine());
                    string itemname = readFile.ReadLine();
                    string itemdescription = readFile.ReadLine();
                    string rarity = readFile.ReadLine();
                    string quantity = readFile.ReadLine();
                    int price = int.Parse(readFile.ReadLine());

                    IDA.Treasure.Add(new Treasure(id,itemname, itemdescription, rarity, quantity, price));
                }


            }
        }
    }
}
