using TeamJaxConsoleGame.Lib.Enumerations;

namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    class Sword : Item
    {
        public const int swordDamage = 40;

        public Sword(string name, int price)
            : base(name, price, ItemType.Sword)
        {
        }

    }
}
