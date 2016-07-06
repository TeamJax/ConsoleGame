using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Constants;
using TeamJaxConsoleGame.Lib.Enumerations;


namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    class Pot : Item
    {
        public const int potPrice = 5;
        public const int potHealing = 30;

        public Pot(string name)
            : base(name, Pot.potPrice, ItemType.Pot)
        {
        }

    }
}
