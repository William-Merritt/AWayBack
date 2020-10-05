using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Items : Inventory_Item
    {

        public Items(int id, string itemname, string itemdescription, string size, string quantity, int price)
            : base(itemname, itemdescription, price)
        {
            Size = size;

            Quantity = quantity;

            ID = id;
        }

        public string Quantity { get; set; }
        public string Size { get; set; }
        private int ID { get; set; }



    }
}
