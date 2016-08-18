using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Srp.Solution
{
    public class Book
    {
        public string Title {get;set; }
        public string Author { get; set; }
        public string[] Pages { get; set; }
        public int CurrentPage { get; set; }

        public string GetPage()
        {
            return Pages[CurrentPage];
        }
    }
}
