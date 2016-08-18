using Ocp_Pacman.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp_Pacman
{
    public class Ghost
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public IStrategy Strategy { get; set; }

        public Ghost(string name, IStrategy strategy)
        {
            Name = name;
            Strategy = strategy;
        }

        public void Chase(Pacman pacman)
        {
            //get pacmans position and move towards hims
            Strategy.Chase(Name, pacman);
        }
    }
}
