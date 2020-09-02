using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWorld.Rooms[] Rooms = { new GameWorld.Rooms("PlanetSurface", "", ""),
                                              new GameWorld.Rooms("CaveEntrance", "" , ""),
                                             new GameWorld.Rooms("StarCraftBack", "" , ""),
                                             new GameWorld.Rooms("StarCraftMiddle", "" , ""),
                                             new GameWorld.Rooms("StarCraftFront", "" , "") };// ARRAY FOR ROOMS
        }
    }
}
