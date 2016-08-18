using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp2.Problem
{
    public interface ISettings
    {
        void Load();
        void Save();
    }
}
