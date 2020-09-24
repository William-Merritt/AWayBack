using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameWorld
{
    public static class IDA
    {
        public static readonly List<Rooms> Room = new List<Rooms>();



        public static Rooms FindID(int id)
        {
            return Room.SingleOrDefault(x => x.ID == id);
        }
    }

}
