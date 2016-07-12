namespace TeamJaxConsoleGame.Lib.Entities
{
    using Enumerations;
    using Interfaces;

    public abstract class Item : GameObject, IItem
    {
        public int Price { get; protected set; }
        public ItemType ItemType { get; set; }

        public Item(string name, int price, ItemType itemType) :
            base(name)
        {
            this.Price = price;
            this.ItemType = itemType;
        }

        public override string GiveDescription()
        {
            return string.Format("This is {0}, which is a {1}. It costs {2} ", this.Name, this.ItemType.ToString(), this.Price);
        }
    }
}