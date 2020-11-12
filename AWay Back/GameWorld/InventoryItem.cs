using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    // class which weapon,item,treasure and potions inherit from
    public class Inventory_Item 
    {
        // Fields
        private Items _newItem;
        private int _quantity;
        // Constructors

        // Properties
        public Items newItem { get { return _newItem; } set { _newItem = value;}}

        public int Quantity { get { return _quantity; } set { _quantity = value;} }

        public int ItemID { get { return newItem.ID; } }

        public string Description { get { return Quantity > 1 ? newItem.} }
    }
}
