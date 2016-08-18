using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp2.Solution
{
    public class UserSettings : ISettings, IPersistedSettings
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
