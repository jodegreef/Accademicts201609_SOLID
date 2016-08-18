using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Srp.Solution
{
    public class BookPersistence
    {
        public void SaveProgress(Book book, string filepath)
        {
            File.WriteAllText(filepath, book.CurrentPage.ToString());
        }
    }
}
