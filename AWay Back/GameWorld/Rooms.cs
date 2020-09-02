using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Rooms
    {

        //Fields
        private string _roomname;
        private string _description;
        private string _exits;


        //constructors
        public Rooms()
        {
            RoomName = "";

            Description = "";

            Exits = "";
        }
        //custom
        public Rooms(string roomname, string description, string exits)
        {
            RoomName = roomname;
            Description = description;
            Exits = exits;

        }
        //fullproperties
        public string RoomName
        {
            get
            {
                return _roomname;
            }
            set
            {
                _roomname = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public string Exits
        {
            get
            {
                return _exits;
            }
            set
            {
                _exits = value;
            }
        }
    }
}
