namespace TeamJaxConsoleGame.Lib.Entities.Skills.Abstract
{
    using System;
    using Common;
    using Constants;
    using Interfaces;

    public abstract class Skill : GameObject, ISkill
    {   
        private int successChance;
        private string description;

        protected Skill(string name, int successChance, string description)
            : base(name)
        {
            this.SuccessChance = successChance;
            this.Description = description;
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

        public string Description
        {
            get
            {
                return this.description;                
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(ValidatorConstants.ValueCannotBeNull, "Skill description"));
                this.description = value;                
            }
        }
    }
}