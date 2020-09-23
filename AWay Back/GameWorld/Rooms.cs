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
        private string _mobs;
        private string _exits;


        //constructors
        public Rooms()
        {
            RoomName = "";

            Description = "";

            Mobs = "";

            Exits = "";
        }
        //custom
        public Rooms(string roomname, string description, string mobs, string exits)
        {
            RoomName = roomname;
            Description = description;
            Mobs = mobs;

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
        public string Mobs
        { 
            get
            {
                return _mobs;
            }
            set
            {
                _mobs = value;
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
