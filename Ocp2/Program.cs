using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp2.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var cashRegister = new CashRegister();

            var pizza1 = new Margherita();
            var pizza2 = new Hawaii();
            //var pizza3 = new ExtraPeppers(new ExtraCheese(new Hawaii()));
            var pizza3 = new Hawaii();

            var total = cashRegister.GetTotalPrice(new Pizza[] { pizza1, pizza2, pizza3 });

            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
