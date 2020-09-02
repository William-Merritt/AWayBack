using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Weapons : Inventory_Item
    {


        public Weapons(string itemname, string itemdescription, string size, string damage, int price)
            : base(itemname, itemdescription, price)
        {
            Size = size;
            Damage = damage;
        }

        public string Size { get; set; }
        public string Damage { get; set; }

    }
}
