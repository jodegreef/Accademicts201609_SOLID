using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ocp_Pacman
{
    public class Game
    {
        private Pacman _pacman;
        private Ghost[] _ghosts;

        public Game()
        {
            _pacman = new Pacman();
            _ghosts = new Ghost[] { new Ghost("Blinky"), new Ghost("Pinky"), new Ghost("Inky"), new Ghost("Clyde") };
        }

        public void Play()
        {
            while (true)
            {
                _pacman.Move();
                foreach (var ghost in _ghosts)
                {
                    ghost.Chase(_pacman);
                }

                Thread.Sleep(1000);
                Console.WriteLine("\nnext turn");
            }
        }
    }
}
