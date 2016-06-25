namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;
    using Enumerations;

    public abstract class Ability : GameObject
    {
        private AbilityType type;
        private int resourceCost;
        private int abilityPower;
        private string description;

        public Ability(string name, int resourceCost, int abilityPower, string description = null)           
        {
            this.Name = name;
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

        public abstract void UseAbility(Hero targetHero);     
    }
}
