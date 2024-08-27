using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay2CSharp
{
    [Flags]
    internal enum Role : byte
    {
        Admin = 1, 
        Accountant = 2  , 
        Stock  = 4, 
        Reception = 8
    }
}
