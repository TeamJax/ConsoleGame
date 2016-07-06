using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Constants;
using TeamJaxConsoleGame.Lib.Enumerations;

namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    class Sword : Item
    {
        public const int swordPrice = 20;
        public const int swordDamage = 40;

        public Sword(string name)
            : base(name, Sword.swordPrice, ItemType.Sword)
        {
        }

    }
}
