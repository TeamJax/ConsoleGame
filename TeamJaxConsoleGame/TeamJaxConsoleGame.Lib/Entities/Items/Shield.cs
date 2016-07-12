namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    using Enumerations;
    using Interfaces;

    public class Shield : Item, IAttackItem, IDefenseItem
    {
        private const int shieldDamage = 5;
        private const int shieldProtection = 30;

        public Shield(string name, int price)
            : base(name, price, ItemType.Shield)
        {
            this.Damage = shieldDamage;
            this.Defense = shieldProtection;
        }

        public int Damage
        {
            get; set;
        }

        public int Defense
        {
            get; set;
        }

        public override string GiveDescription()
        {
            return string.Format("{0}, has {1} defense power and does {2} damage", 
                base.GiveDescription(),this.Defense, this.Damage);
        }

    }
}
