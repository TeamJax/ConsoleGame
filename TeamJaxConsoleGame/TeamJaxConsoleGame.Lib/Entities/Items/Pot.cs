using TeamJaxConsoleGame.Lib.Enumerations;


namespace TeamJaxConsoleGame.Lib.Entities.Items
{
    class Pot : Item
    {
        public const int potHealing = 30;

        public Pot(string name, int price)
            : base(name, price, ItemType.Pot)
        {
        }

    }
}
