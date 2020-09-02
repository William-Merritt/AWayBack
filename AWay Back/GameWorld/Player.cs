using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld
{
    public class Player : LivingCreature
    {
        // Fields

        //private string _firstName;
        //private string _lastName;
        private string _password;
        private string _playerClass;

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
