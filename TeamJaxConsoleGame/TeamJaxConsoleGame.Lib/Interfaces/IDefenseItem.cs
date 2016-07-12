using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamJaxConsoleGame.Lib.Interfaces
{
    interface IDefenseItem : IItem
    {
        int Defense { get; set; }
    }
}
