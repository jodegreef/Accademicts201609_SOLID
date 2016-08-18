using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp_Pacman.Strategies
{
    public class AllStrategies : IStrategy
    {
        private DateTime _timestamp = DateTime.Now;

        private IStrategy[] _strategies = { new Chaser(), new FourStepsAhead(), new RandomPattern(), new FixedPattern() };
        private int _currentStrategy = 0;

        public void Chase(string ghostName, Pacman pacman)
        {
            _strategies[_currentStrategy].Chase(ghostName, pacman);

            if (IsTimeElapsed())
            {
                SwitchToNextStrategy();
            }
        }

        private bool IsTimeElapsed()
        {
            return (DateTime.Now - _timestamp).TotalMilliseconds > 5000;
        }

        private void SwitchToNextStrategy()
        {
            _currentStrategy++;
            _timestamp = DateTime.Now;

            if (_currentStrategy >= _strategies.Count())
            {
                _currentStrategy = 0;
            }
        }
    }
}
