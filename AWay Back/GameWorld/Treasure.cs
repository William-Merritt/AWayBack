using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Treasure : Inventory_Item
    {


        public Treasure(string itemname, string itemdescription, string rarity, string quantity, int price)
            : base(itemname, itemdescription, price)
        {
            Rarity = rarity;

            Quantity = quantity;
        }

        public string Quantity { get; set; }

        public string Rarity { get; set; }
    }
}
