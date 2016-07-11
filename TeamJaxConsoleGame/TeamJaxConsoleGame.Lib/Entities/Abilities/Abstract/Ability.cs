namespace TeamJaxConsoleGame.Lib.Entities.Abilities.Abstract
{
    using System;
    using Enumerations;
    using Interfaces;

    public abstract class Ability : GameObject, IAbility
    {
        private AbilityType type;
        private int resourceCost;
        private int abilityPower;
        private string description;

        protected Ability(string name, AbilityType type, int resourceCost, int abilityPower, string description)   
            : base(name)        
        {
            this.Type = type;
            this.ResourceCost = resourceCost;
            this.AbilityPower = abilityPower;
            this.Description = description;
        }

        public AbilityType Type
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

        public int ResourceCost
        {
            get
            {
                return this.resourceCost;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Resource cost cannot be negative!");
                }

                this.resourceCost = value;
            }
        }

        public int AbilityPower
        {
            get
            {
                return this.abilityPower;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Ability power cannot be negative!");
                }

                this.abilityPower = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Description cannot be empty!");
                }

                this.description = value;
            }
        }

        public abstract void Activate(IFighter target);       
    }
}
