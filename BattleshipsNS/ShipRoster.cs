﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    public class ShipRoster : IShipRoster
    {
        // Fields, Properties
        public Ship[] Roster { get; private set; }

        // Constructor Declaration of Class
        public ShipRoster(ShipTypes[] roster)
        {
            Roster = new Ship[roster.Length];

            for(int i = 0; i < roster.Length; i++)
            {
                Roster[i] = new Ship(roster[i], i+1);
            }
        }

        // Methods, Events, Operators
        public bool CheckRosterSunk()
        {
            bool AllSunk = false;
           
            foreach(Ship ship in Roster)
            {
                ship.UpdateSunkFlag();
                if (ship.SunkFlag)
                {
                    AllSunk = true;
                }
                else
                {
                    AllSunk = false;
                }
            }

            return AllSunk;
        }

    }
}
