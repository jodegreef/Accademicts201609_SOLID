using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp_Pacman.Strategies
{
    public interface IStrategy
    {
        void Chase(string ghostName, Pacman pacman);
    }
}
