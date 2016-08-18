using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();

            Process(rect);

            Console.ReadLine();
        }

        static void Process(Rectangle rect)
        {
            rect.Width = 5;
            rect.Height = 10;
            Console.Write(string.Format("Width: {0}, Height: {1}", rect.Width, rect.Height));
        }
    }
}
