using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Treasure : Inventory_Item
    {


        public Treasure(int id, string itemname, string itemdescription, string rarity, string quantity, int price)
            : base(itemname, itemdescription, price)
        {
            Rarity = rarity;

            Quantity = quantity;
            ID = id;
        }

        public string Quantity { get; set; }

        public string Rarity { get; set; }
        private int ID { get; set; }
    }
}
