using TeamJaxConsoleGame.Lib.Enumerations;
using TeamJaxConsoleGame.Lib.Interfaces;


namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    public class Stick : Item, IAttackItem
    {
        private const int stickDamage = 5;

        public Stick(string name, int price)
            : base(name, price, ItemType.Stick)
        {
            this.Damage = stickDamage;
        }

        public int Damage { get; set; }

        public override string GiveDescription()
        {
            return string.Format("{0} and does {1} damage", base.GiveDescription(), this.Damage);
        }
    }
}
