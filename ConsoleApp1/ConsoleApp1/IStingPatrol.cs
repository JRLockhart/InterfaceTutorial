﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IStingPatrol
    {

        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}
