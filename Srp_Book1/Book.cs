using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srp_Book1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void TurnPage()
        {
            //turn to next page
        }

        public string PrintPage()
        {
            return "DummyPage";
        }
    }
}
