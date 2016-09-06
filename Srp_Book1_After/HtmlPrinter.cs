using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srp_Book1_After
{
    public class HtmlPrinter
    {
        public string Print(string pageContent)
        {
            return string.Format("<div class='page'>{0}</div>", pageContent);
        }
    }
}
