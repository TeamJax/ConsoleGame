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

        public Stick(string name, int price)
            : base(name, price, ItemType.Stick)
        {
        }

    }
}
