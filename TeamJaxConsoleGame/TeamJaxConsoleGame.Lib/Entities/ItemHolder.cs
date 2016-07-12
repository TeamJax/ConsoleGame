namespace TeamJaxConsoleGame.Lib.Entities
{
    using System.Collections.Generic;

    using Interfaces;

    public abstract class ItemHolder : GameObject
    {
        public IList<IItem> Items { get; set; }
    }
}
