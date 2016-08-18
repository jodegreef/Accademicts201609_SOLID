using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Srp.Solution
{
    public class BookDisplay
    {
        public void ShowPage(Book book)
        {
            Console.WriteLine(book.GetPage());
        }
    }
}
