﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp_Pacman.Strategies
{
    public class FixedPattern : IStrategy
    {
        public void Chase(string ghostName, Pacman pacman)
        {
            Console.WriteLine(string.Format("{0} using fixed pattern", ghostName));
        }
    }
}
