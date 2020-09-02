using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Items : Inventory_Item
    {



        public Items(string itemname, string itemdescription, string size, string quantity, int price)
            : base(itemname, itemdescription, price)
        {
            Size = size;

            Quantity = quantity;
        }

        public string Quantity { get; set; }

        public string Size { get; set; }1
    }
}
