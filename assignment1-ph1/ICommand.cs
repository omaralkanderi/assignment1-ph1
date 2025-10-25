using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_ph1
{
    internal interface ICommand
    {
        string Name { get; }
        void Execute(CommandCenter commandCenter);
    }
}
