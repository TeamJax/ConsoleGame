namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;

    public abstract class GameObject
    {
        public string Name { get; set; }

        public virtual string Describe()
        {
            return String.Format("This is {0}", this.Name);
        }
    }
}
