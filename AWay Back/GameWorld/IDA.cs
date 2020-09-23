using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameWorld
{
    public static class IDA
    {
        public static readonly List<Rooms> CurrentRoom = new List<Rooms>();



        public static Rooms FindID(int id)
        {
            return CurrentRoom.SingleOrDefault(i => i.ID == id);
        }
    }

}
