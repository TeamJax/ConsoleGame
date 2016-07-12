using System;
using TeamJaxConsoleGame.Lib.Enumerations;
using TeamJaxConsoleGame.Lib.Interfaces;

namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    class Sword : Item, IAttackItem
    {
        public const int swordDamage = 40;

        public Sword(string name, int price)
            : base(name, price, ItemType.Sword)
        {
            this.Damage = swordDamage;
        }

        public int Damage
        {
            get; set;
        }

        public override string GiveDescription()
        {
            return string.Format("{0} and does {1} damage", base.GiveDescription(), this.Damage);
        }

    }
}
