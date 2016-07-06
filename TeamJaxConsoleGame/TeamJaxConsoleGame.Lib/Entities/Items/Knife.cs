using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Constants;
using TeamJaxConsoleGame.Lib.Enumerations;


namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    public class Knife : Item
    {
        public const int knifePrice = 5;
        public const int knifeDamage = 20;

        public Knife(string name)
            : base(name, Knife.knifePrice, ItemType.Knife)
        {
        }

    }
}
