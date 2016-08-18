using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Before
{
    public class AreaCalculator
    {
        public double Area(Rectangle[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;
            }

            return area;
        }
    }
}
