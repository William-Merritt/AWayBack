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
            Playerlibrary.Rooms[] Rooms = { new Playerlibrary.Rooms("PlanetSurface", "", ""),
                                              new Playerlibrary.Rooms("CaveEntrance", "" , ""),
                                             new Playerlibrary.Rooms("StarCraftBack", "" , ""),
                                             new Playerlibrary.Rooms("StarCraftMiddle", "" , ""),
                                             new Playerlibrary.Rooms("StarCraftFront", "" , "") };// ARRAY FOR ROOMS
        }
    }
}
