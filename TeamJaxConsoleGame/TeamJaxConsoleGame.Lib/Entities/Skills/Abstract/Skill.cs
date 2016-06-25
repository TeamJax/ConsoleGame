namespace TeamJaxConsoleGame.Lib.Entities.Skills
{
    using System;
    using Enumerations;

    public abstract class Skill : GameObject
    {
        private SkillType type;
        private int successChance;

        public Skill(string name, SkillType type, int successChance)
        {
            this.Name = name;
            this.type = type;
            this.SuccessChance = successChance;
        }

        public SkillType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
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