﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsNS
{
    interface IOutputHandler
    {
        void GenerateMessage(int MessageID);

        void DisplayPlayGrid(GameBoard playGrid);
    }
}
