using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace GameWorld
{
    public class Create
    {
        public static void PromptForCreation()
        {
            string inputString;                         //Will hold all user input

            Console.Write("What are you making?");
            Console.WriteLine("Mob, Room, Weapon, Treasure, Item, or Potions:  ");
            inputString = Console.ReadLine();

            switch (inputString.ToLower())
            {
                case "mob":
                    NewMob();
                    break;

                case "room":
                    NewRoom();
                    break;

                case "weapon":
                    NewWeapon();
                    break;

                case "treasure":
                    NewTreasure();
                    break;

                case "item":
                    NewItem();
                    break;

                case "potions":
                    NewPotion();
                    break;

                default:
                    Console.WriteLine("Error! Incorrect Value Entered.");
                    break;
            }
        }

        public static void NewMob()
        {
            string inputString;                     //To hold all of the user input
            int id;
            string name;
            string mobInfo;
            string mobDmgType;
            string mobWeakness;
            int health;
            string race;
            bool done = false;

            while (done == false)
            {
                Console.WriteLine("What is the ID for the mob?");
                Console.Write("1 - 100");
                inputString = Console.ReadLine();

                if (inputString != null)
                {
                    id = Convert.ToInt32(inputString);
                    if (id > 1 && id <= 100)
                    {
                        foreach (Mobs mob in IDA.Mob.ToList())
                        {
                            if (mob.ID == id)
                            {
                                Console.WriteLine("Error. A mob already contains that ID.");
                            }
                        }

                        Console.WriteLine("What is the Mob ID: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("What is the Mob Name: ");
                        name = Console.ReadLine();

                        Console.WriteLine("What is the Mob Info: ");
                        mobInfo = Console.ReadLine();

                        Console.WriteLine("What is the Mob Damage Type: ");
                        mobDmgType = Console.ReadLine();

                        Console.WriteLine("What is the Mob's Weakness: ");
                        mobWeakness = Console.ReadLine();

                        Console.WriteLine("Amount of HP: ");
                        health = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("What is the race of this Mob: ");
                        race = Console.ReadLine();

                        IDA.Mob.Add(new Mobs(id, name, mobInfo, mobDmgType, mobWeakness, health, race));

                        if (File.Exists(@"../../../GameWorld/TextFiles/Mobs.txt"))
                        {
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", "" + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", id.ToString() + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", name + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", mobInfo + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", mobDmgType + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", mobWeakness + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", health.ToString() + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Mobs.txt", race);

                        }
                        done = true;
                    }
                }
            }
        }
        public static void NewRoom()
        {
            string inputString;
            int id;
            string roomName;
            string roomDescription;
            int exitN;
            int exitE;
            int exitW;
            int exitS;
            int mobId;
            bool done = false;

            while (done == false)
            {
                Console.WriteLine("What is the ID for this Room: ");
                Console.WriteLine("101 - 200");
                inputString = Console.ReadLine();

                if (inputString != null)
                {
                    id = Convert.ToInt32(inputString);
                    if (id > 101 && id <= 199)
                    {
                        foreach (Rooms room in IDA.Room.ToList())
                        {
                            if (room.ID == id)
                            {
                                Console.WriteLine("Error. A room already contains that ID.");
                            }
                        }

                        Console.WriteLine("What is the name of this room: ");
                        roomName = Console.ReadLine();

                        Console.WriteLine("What is the description for this room: ");
                        roomDescription = Console.ReadLine();

                        Console.WriteLine("Does this room have an exit to the north?");
                        Console.Write("If so enter a 0 - 9. If not enter a -1: ");
                        exitN = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Does this room have an exit to the east?");
                        Console.Write("If so enter a 0 - 9. If not enter a -1: ");
                        exitE = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Does this room have an exit to the west?");
                        Console.Write("If so enter a 0 - 9. If not enter a -1: ");
                        exitW = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Does this room have an exit to the south?");
                        Console.Write("If so enter a 0 - 9. If not enter a -1: ");
                        exitS = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Does this room have a mob?\n" +
                            "If so what is the ID? If not enter a -1: ");
                        mobId = Convert.ToInt32(Console.ReadLine());

                        IDA.Room.Add(new Rooms(id, roomName, roomDescription, exitN, exitE, exitS, exitW, mobId));

                        if (File.Exists(@"../../../GameWorld/TextFiles/Rooms.txt"))
                        {
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Rooms.txt", "" + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Rooms.txt", id.ToString() + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Rooms.txt", roomName + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Rooms.txt", roomDescription + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Rooms.txt", exitN + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Rooms.txt", exitE + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Rooms.txt", exitS + "," + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Rooms.txt", exitW + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Rooms.txt", mobId + Environment.NewLine);

                        }
                        done = true;


                    }
                }
            }
        }

        public static void NewWeapon()
        {
            string inputString;
            int id;
            string itemName;
            string itemDescription;
            string size;
            string damage;
            int price;
            bool done = false;

            while (done == false)
            {
                Console.WriteLine("What is the ID for this Room: ");
                Console.WriteLine("201 - 300");
                inputString = Console.ReadLine();

                if (inputString != null)
                {
                    id = Convert.ToInt32(inputString);
                    if (id > 201 && id <= 300)
                    {
                        foreach (Weapons element in IDA.Weapon.ToList())
                        {
                            if (element.ID == id)
                            {
                                Console.WriteLine("Error. A mob already contains that ID.");
                            }
                        }

                        Console.WriteLine("What is the weapons name: ");
                        itemName = Console.ReadLine();

                        Console.WriteLine("What is the description for this weapon: ");
                        itemDescription = Console.ReadLine();

                        Console.WriteLine("What is the size of this weapon: ");
                        size = Console.ReadLine();

                        Console.WriteLine("How much damage does this weapon do: ");
                        damage = Console.ReadLine();

                        Console.WriteLine("How much does this weapon cost: ");
                        price = Convert.ToInt32(Console.ReadLine());

                        IDA.Weapon.Add(new Weapons(id, itemName, itemDescription, size, damage, price));

                        if (File.Exists(@"../../../GameWorld/TextFiles/Weapons.txt"))
                        {
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Weapons.txt", "" + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Weapons.txt", id.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Weapons.txt", itemName + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Weapons.txt", itemDescription + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Weapons.txt", size + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Weapons.txt", damage + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Weapons.txt", price.ToString() + Environment.NewLine);

                        }
                        done = true;

                    }
                }
            }
        }

        public static void NewTreasure()
        {
            string inputString;
            int id;
            string itemName;
            string itemDescription;
            string rarity;
            string quantity;
            int price;
            bool done = false;

            while (done == false)
            {
                Console.WriteLine("What is the ID for this treasure: ");
                Console.WriteLine("301 - 400");
                inputString = Console.ReadLine();

                if (inputString != null)
                {
                    id = Convert.ToInt32(inputString);
                    if (id > 301 && id <= 400)
                    {
                        foreach (Treasure loot in IDA.Treasure.ToList())
                        {
                            if (loot.ID == id)
                            {
                                Console.WriteLine("Error. A treasure already contains that ID.");
                            }
                        }

                        Console.WriteLine("What is the name of this treasure: ");
                        itemName = Console.ReadLine();

                        Console.WriteLine("What is the description for this treasure: ");
                        itemDescription = Console.ReadLine();

                        Console.WriteLine("What is the rarity of this treasure\n" +
                            "common, uncommon, rare, legendary: ");
                        rarity = Console.ReadLine();

                        Console.WriteLine("How much of this treasure is avaliable: ");
                        quantity = Console.ReadLine();

                        Console.WriteLine("How much can this treasure be sold for: ");
                        price = Convert.ToInt32(Console.ReadLine());

                        IDA.Treasure.Add(new Treasure(id, itemName, itemDescription, rarity, quantity, price));

                        if (File.Exists(@"../../../GameWorld/TextFiles/Treasure.txt"))
                        {
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Treasure.txt", "" + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Treasure.txt", id.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Treasure.txt", itemName + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Treasure.txt", itemDescription + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Treasure.txt", rarity + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Treasure.txt", quantity + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Treasure.txt", price + Environment.NewLine);
                        }
                        done = true;

                    }
                }
            }
        }

        public static void NewItem()
        {
            string inputString;
            int id;
            string itemName;
            string itemDescription;
            string size;
            string quantity;
            int price;
            bool done = false;

            while (done == false)
            {
                Console.WriteLine("What is the ID for this treasure: ");
                Console.WriteLine("401 - 500");
                inputString = Console.ReadLine();

                if (inputString != null)
                {
                    id = Convert.ToInt32(inputString);
                    if (id > 401 && id <= 500)
                    {
                        foreach (Items item in IDA.Item.ToList())
                        {
                            if (item.ID == id)
                            {
                                Console.WriteLine("Error. A item already contains that ID.");
                            }
                        }

                        Console.WriteLine("What is the name of this item: ");
                        itemName = Console.ReadLine();

                        Console.WriteLine("What is the description for this item: ");
                        itemDescription = Console.ReadLine();

                        Console.WriteLine("How much space does this item take up: ");
                        size = Console.ReadLine();

                        Console.WriteLine("How many instances of this item is there: ");
                        quantity = Console.ReadLine();

                        Console.WriteLine("How muuch will this item sell for: ");
                        price = Convert.ToInt32(Console.ReadLine());

                        IDA.Item.Add(new Items(id, itemName, itemDescription, size, price));

                        if (File.Exists(@"../../../GameWorld/TextFiles/Items.txt"))
                        {
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Items.txt", "" + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Items.txt", id.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Items.txt", itemName + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Items.txt", itemDescription + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Items.txt", size + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Items.txt", quantity + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Items.txt", price + Environment.NewLine);
                        }
                        done = true;
                    }
                }
            }
        }

        public static void NewPotion() 
        {
            string inputString;
            int id;
            string itemName;
            string itemDescription;
            string healingValue;
            string quantity;
            int price;
            bool done = false;

            while (done == false)
            {
                Console.WriteLine("What is the ID for this potion : ");
                Console.WriteLine("991 - 1000");
                inputString = Console.ReadLine();

                if (inputString != null)
                {
                    id = Convert.ToInt32(inputString);
                    if (id > 991 && id <= 1000)
                    {
                        foreach (Potions pot in IDA.Potion.ToList())
                        {
                            if (pot.ID == id)
                            {
                                Console.WriteLine("Error. A potion already contains that ID.");
                            }
                        }

                        Console.WriteLine("What is the name of this potion: ");
                        itemName = Console.ReadLine();

                        Console.WriteLine("What is the description for this potion: ");
                        itemDescription = Console.ReadLine();

                        Console.WriteLine("What is the recovery value of this poition: ");
                        healingValue= Console.ReadLine();

                        Console.WriteLine("How many instances of this potion is there: ");
                        quantity = Console.ReadLine();

                        Console.WriteLine("How muuch will this potion sell for: ");
                        price = Convert.ToInt32(Console.ReadLine());

                        IDA.Item.Add(new Items(id, itemName, itemDescription, healingValue, price));

                        if (File.Exists(@"../../../GameWorld/TextFiles/Potions.txt"))
                        {
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Potions.txt", "" + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Potions.txt", id.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Potions.txt", itemName + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Potions.txt", itemDescription + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Potions.txt", healingValue + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Potions.txt", quantity + Environment.NewLine);
                            File.AppendAllText(@"../../../GameWorld/TextFiles/Potions.txt", price + Environment.NewLine);
                        }
                        done = true;
                    }
                }
            }
        }
    
    }   
}

