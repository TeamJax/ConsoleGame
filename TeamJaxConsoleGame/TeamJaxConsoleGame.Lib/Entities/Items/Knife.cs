namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    using Enumerations;
    using Interfaces;

    public class Knife : Item, IAttackItem
    {
        private const int knifeDamage = 20;

        public Knife(string name, int price)
            : base(name, price, ItemType.Knife)
        {
            this.Damage = knifeDamage;
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
