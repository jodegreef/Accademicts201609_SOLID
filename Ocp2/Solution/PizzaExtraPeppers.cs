using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp2.Solution
{
    public class PizzaExtraPeppers : Pizza
    {
        private Pizza _pizza;

        public PizzaExtraPeppers(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override decimal Price { get { return _pizza.Price + 0.75m; } }
    }
}
