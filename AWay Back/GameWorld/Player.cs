using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Player : LivingCreature
    {
        // Fields
        private string _password;
        private string _name;
        private string _playerClass;
        private static Rooms _currentRoom;   //To get the players current location.
        public static Player _player;
        private static Mobs _currentMob;     // To find the current mob in the room. 

        // Constructor
        public Player()
        {
            Name = "";
            PlayerClass = "";
            Password = "";
            Health = 0;
            Race = "";
        }
        public Player(string name, string playerClass, string password, int health, string race)
                        : base(health, race)
        {
            Name = name;
            PlayerClass = playerClass;
            Password = _password;
            //CurrentRoom = IDA.Room[0];
        }

        //Properties

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public string Name { get { return _name; } set { _name = value; } }

        public string PlayerClass
        {
            get
            {
                return _playerClass;
            }
            set
            {
                _playerClass = value;
            }
        }
        public static Rooms CurrentRoom { get { return _currentRoom; } set { _currentRoom = value; } }

        public static Mobs CurrentMob { get { return _currentMob; } set { _currentMob = value; } }
    }
}
