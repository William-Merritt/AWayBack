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
        private int _id;                                    //To hold the Room's ID number
        private int _exitNorth;
        private int _exitEast;
        private int _exitSouth;
        private int _exitWest;
        private int _mobId;
        private Mobs _mob;

        //constructors
        public Rooms()
        {
            RoomName = "";

            Description = "";
        }
        public Rooms(int id, string roomname, string description, int exitN, int exitE, int exitS, int exitW, int mobId)
        {
            RoomName = roomname;
            Description = description;
            ID = id;
            ExitEast = exitE;
            ExitNorth = exitN;
            ExitWest = exitW;
            ExitSouth = exitS;

            // Adding a random monster to the list to use later inside of rooms
            if (mobId != 4)
            {
                if (mobId > 1)
                {
                    Random rand = new Random();

                    int getNewMob = rand.Next(0, 4);
                    RoomsMob = new Mobs(IDA.Mob[getNewMob]);
                    RoomMobs.Add(RoomsMob);
                }
            }
            else 
            {
                RoomMobs.Add(IDA.FindMobID(mobId));
            }
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

        public int ID { get { return _id; } set { _id = value; } }

        public int ExitNorth { get { return _exitNorth; } set { _exitNorth = value; } }

        public int ExitEast { get { return _exitEast; } set { _exitEast = value; } }

        public int ExitWest { get { return _exitWest; } set { _exitWest = value; } }
    
        public int ExitSouth { get { return _exitSouth; } set { _exitSouth = value; } }

        public int MobId { get { return _mobId; } set { _mobId = value; } }

        public Mobs RoomsMob { get { return _mob; } set { _mob = value; } }

        public List<Mobs> RoomMobs = new List<Mobs>();
    }

}
