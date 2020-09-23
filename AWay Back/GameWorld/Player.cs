using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Player : LivingCreature
    {
        // Fields
        private string _password;
        private string _playerClass;
        private static Rooms _currentRoom;                  //To get the players current location.

        public bool IsAuthenticated;

        // Constructor
        public Player()
        {
            FirstName = "";
            LastName = "";
            PlayerClass = "";
            Password = "";
            Health = 0;
            Race = "";
        }
        public Player(string firstName, string lastName, string playerClass, string password, int health, string race)
                        : base(firstName, lastName, health, race)
        {
            PlayerClass = playerClass;
            Password = _password;
            CurrentRoom = IDA.CurrentRoom[0];
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

        // Auto Properties
        public static Rooms CurrentRoom { get { return _currentRoom; } set { _currentRoom = value; } }


        //Creating Password Check
        public bool Logon(string password)
        {
            if (Password == password)
            {
                IsAuthenticated = true;
            }
            return IsAuthenticated;
        }

        public bool GetIsAuthenticated()
        {
            return IsAuthenticated;
        }
    }
}
