using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Weapons : Inventory_Item
    {


        public Weapons(int id, string itemname, string itemdescription, string size, string damage, int price)
            : base(itemname, itemdescription, price)
        {
            Size = size;
            Damage = damage;
            ID = id;
        }

        public string Size { get; set; }
        public string Damage { get; set; }
        private int ID { get; set; }

    }
}
