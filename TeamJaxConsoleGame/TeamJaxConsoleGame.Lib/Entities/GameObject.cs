namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;

    using Interfaces;

    public abstract class GameObject : IGameObject
    {
        public string Name { get; set; }

        public virtual string Describe()
        {
            return String.Format("This is {0}", this.Name);
        }
    }
}
