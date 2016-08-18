using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp2.Solution
{
    public class CashRegister
    {
        public decimal GetTotalPrice(Pizza[] pizzas)
        {
            decimal total = 0;

            total = pizzas.Sum(x => x.Price);

            return total;
        }
    }
}
