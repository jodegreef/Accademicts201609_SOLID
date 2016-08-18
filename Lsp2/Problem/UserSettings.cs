using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp2.Problem
{
    public class UserSettings : ISettings
    {
        public void Load()
        {
            //load from somehwere;
        }

        public void Save()
        {
            //save from somewhere;
        }
    }
}
