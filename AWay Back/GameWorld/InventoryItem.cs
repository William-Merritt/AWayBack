using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    // class which weapon,item,treasure and potions inherit from
    public class Inventory_Item
    {


        public Inventory_Item()
        {
            itemName = " ";
            itemDescription = " ";
            Price = 0;
        }

        public Inventory_Item(string itemname, string itemdescription, int price)
        {
            itemName = itemname;
            itemDescription = itemdescription;
            Price = price;

        }

        public int Price { get; set; }
        public string itemName { get; set; }
        public string itemDescription { get; set; }




    }
}
