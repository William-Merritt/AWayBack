using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Items
    {

        // Fields
        private int _id;
        private string _itemname;
        private string _itemdescription;
        private string _size;
        private int _price;

        public Items(int id, string itemname, string itemdescription, string size, int price)
        {
            ID = id;
            ItemName = itemname;
            ItemDescription = itemdescription;
            Size = size;
            Price = price;
        }

        public string Size { get; set; }
       
        public int ID { get { return _id; } set { _id = value; } }

        public string ItemName { get { return _itemname; } set { _itemname = value; } }

        public string ItemDescription { get { return _itemdescription; } set { _itemdescription = value; } }

        public int Price { get { return _price; } set { _price = value; } }


    }
}
