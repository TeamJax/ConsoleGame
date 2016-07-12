using TeamJaxConsoleGame.Lib.Enumerations;


namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    public class Stick : Item
    {

        public Stick(string name, int price, int stickDamage)
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
