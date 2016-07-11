using TeamJaxConsoleGame.Lib.Interfaces;

namespace TeamJaxConsoleGame.Lib.Entities.Skills.Abstract
{
    using System;

    public abstract class Skill : GameObject, ISkill
    {   
        private int successChance;

        protected Skill(string name, int successChance)
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

        public override string GiveDescription()
        {
            return string.Format($"Your {this.Name} has a {this.successChance}% chance to be performed.");
        }
    }
}