namespace TeamJaxConsoleGame.Lib.Entities
{
    using System.Collections.Generic;

    public abstract class ItemHolder : GameObject
    {
        public IEnumerable<Item> Items { get; set; }
    }
}
