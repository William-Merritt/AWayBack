﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Potions : Inventory_Item
    {


        public Potions(int id, string itemname, string itemdescription, string healingvalue, string quantitiy, int price)
            :base(itemname, itemdescription, price)
        {
            healingValue = healingvalue;
            Quantity = quantitiy;
            ID = id;
        }
        public string healingValue { get; set; }
        public string Quantity { get; set; }
        public int ID { get; set; }
    }
}
