namespace TeamJaxConsoleGame.Lib.Entities
{
    using System.Collections.Generic;

    public abstract class Person : GameObject
    {
        public IEnumerable<Item> Items { get; set; }
    }
}
