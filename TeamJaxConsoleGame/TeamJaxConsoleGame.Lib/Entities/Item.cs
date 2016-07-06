namespace TeamJaxConsoleGame.Lib.Entities
{
    using Enumerations;

    public abstract class Item : GameObject
    {
        public ItemType ItemType { get; set; }
    }
}