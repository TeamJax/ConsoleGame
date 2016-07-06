namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;

    using Interfaces;

    public abstract class GameObject : IGameObject
    {
        public string Name { get; set; }

        public GameObject(string name = null)
        {
            this.Name = name;
        }

        public virtual string Describe()
        {
            return String.Format("This is {0}", this.Name);
        }
    }
}
