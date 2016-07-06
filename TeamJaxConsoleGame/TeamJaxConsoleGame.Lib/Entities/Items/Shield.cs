using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Constants;
using TeamJaxConsoleGame.Lib.Enumerations;


namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    class Shield : Item
    {
        public const int shieldDamage = 5;
        public const int shieldProtection = 30;

        public Shield(string name, int price)
            : base(name, price, ItemType.Shield)
        {
        }


    }
}
