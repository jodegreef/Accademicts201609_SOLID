﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp2.Solution
{
    public class ReadOnlySettings : ISettings
    {
        public void Load()
        {
            //load from somewhere;
        }
    }
}
