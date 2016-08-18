using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp2.Solution
{
    public class PizzaExtraCheese : Pizza
    {
        private Pizza _pizza;

        public PizzaExtraCheese(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override decimal Price { get { return _pizza.Price + 0.25m; } }
    }
}
