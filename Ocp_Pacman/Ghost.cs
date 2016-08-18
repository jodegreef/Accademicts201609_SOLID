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

        public Ghost(string name)
        {
            Name = name;
        }

        public void Chase(Pacman pacman)
        {
            Console.WriteLine(string.Format("{0} chasing pacman", Name));
            //get pacmans position and move towards hims
        }
    }
}
