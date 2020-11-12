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
        private int _price;
        // Constructors
        public Inventory_Item(Items newItem, int quantity) 
        {
            NewItem = newItem;
            Quantity = quantity;
        }

        // Properties
        public Items NewItem { get { return _newItem; } set { _newItem = value;}}

        public int Quantity { get { return _quantity; } set { _quantity = value;} }

        public int ItemID { get { return NewItem.ID; } }

        public string Description { get { return Quantity > 1 ? NewItem.ItemName; } }

        public int Price { get { return NewItem.Price; } }



    }
}
