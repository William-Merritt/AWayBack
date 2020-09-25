﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GameWorld
{
    public static class Builder
    {
        private static string[] FindNextLine(StreamReader readFile) // TO be used later for monsters.
        {
            string[] lines = readFile.ReadLine().Split(' ');
            return lines;
        }

        public static void Build() 
        {
            using (StreamReader readFile = File.OpenText(@"C:\Users\The King\Documents\GitHub\AWayBack\AWay Back\GameWorld\TextFiles\Rooms.txt")) 
            {
                while (!readFile.EndOfStream) 
                {
                    int id = int.Parse(readFile.ReadLine());
                    string roomName = readFile.ReadLine();
                    string roomDescription = readFile.ReadLine();
                    int exitN = int.Parse(readFile.ReadLine());
                    int exitE = int.Parse(readFile.ReadLine());
                    int exitW = int.Parse(readFile.ReadLine());
                    int exitS = int.Parse(readFile.ReadLine());
                    int mobId = int.Parse(readFile.ReadLine());

                    IDA.Room.Add(new Rooms(id, roomName, roomDescription, exitN, exitE, exitW, exitS, mobId));
                }
            }

            using (StreamReader readFile = File.OpenText(@"C:\Users\The King\Documents\GitHub\AWayBack\AWay Back\GameWorld\TextFiles\Mobs.txt")) 
            {
                while (!readFile.EndOfStream) 
                {
                    int id = int.Parse(readFile.ReadLine());
                    string name = readFile.ReadLine();
                    string mobInfo = readFile.ReadLine();
                    string mobDmgType = readFile.ReadLine();
                    string mobWeakness = readFile.ReadLine();
                    int health = int.Parse(readFile.ReadLine());
                    string mobRace = readFile.ReadLine();

                    IDA.Mob.Add(new Mobs(id, name, mobInfo, mobDmgType, mobWeakness, health, mobRace));
                }
            }
        }
    }
}
