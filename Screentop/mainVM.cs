using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Screentop
{
    internal class MainVM
    {
        public MainVM()
        {
            Tablespace = new TableVM();
        }
        public TableVM Tablespace { get; }

    }
}