using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocp.Solution;

namespace Ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new AreaCalculator();

            var rectangle1 = new Rectangle { Width = 10, Height = 10 };
            var rectangle2 = new Rectangle { Width = 5, Height = 5 };
            var circle = new Circle { Radius = 2 };

            var area = calculator.Area(new Shape[] { rectangle1, rectangle2, circle });

            Console.WriteLine(area);

            Console.ReadLine();

        }
    }
}
