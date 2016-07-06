namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    using System;

    public abstract class Skill : GameObject
    {
        private int successChance;

        public Skill(string name, int successChance)
            : base(name)
        {
            this.SuccessChance = successChance;
        } 

        public int SuccessChance
        {
            get
            {
                return this.successChance;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Success chance cannot be negative!");
                }

                this.successChance = value;
            }
        }

        public override string Describe()
        {
            return string.Format($"Your {this.Name} has a {this.successChance}% chance to be performed.");
        }
    }
}