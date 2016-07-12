using System;
using TeamJaxConsoleGame.Lib.Enumerations;
using TeamJaxConsoleGame.Lib.Interfaces;


namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    class Pot : Item, IHealingItem
    {
        private const int potHealing = 30;

        public Pot(string name, int price)
            : base(name, price, ItemType.Pot)
        {
            this.Heal = potHealing;
        }

        public int Heal
        {
            get; set;
        }

        public override string GiveDescription()
        {
            return string.Format("{0} and has {1} healing power", base.GiveDescription(), this.Heal);
        }

    }
}
