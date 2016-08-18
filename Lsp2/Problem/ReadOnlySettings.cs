using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp2.Problem
{
    public class ReadOnlySettings : ISettings
    {
        public void Load()
        {
            //load from somewhere;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
