namespace TeamJaxConsoleGame.Lib.Entities
{
    using Enumerations;
    using TeamJaxConsoleGame.Lib.Constants;

    public abstract class Item : GameObject
    {
        public int Price { get; protected set; }
        public ItemType ItemType { get; set; }

        public Item(string name, int price, ItemType itemType) :
            base(name)
        {
            this.Price = price;
            this.ItemType = itemType;
        }
    }
}