﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IShip
    {
        string ID { get; }
        int Length { get; }
        bool SunkFlag { get; }
        int Orientation { get; set; }
        (int, int) StartLocation { get; set; }
        GridCell[] Sections { get; }

        void UpdateSections();
        void UpdateSunkFlag();
    }
}
