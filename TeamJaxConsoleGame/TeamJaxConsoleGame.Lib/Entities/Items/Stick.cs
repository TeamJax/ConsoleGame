using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Constants;
using TeamJaxConsoleGame.Lib.Enumerations;


namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    class Stick : Item
    {
        public const int stickDamage = 5;
        public const int stickPrice = 0;

        public Stick(string name)
            : base(name, Stick.stickPrice, ItemType.Stick)
        {
        }

    }
}
