namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;
    using Enumerations;

    public abstract class Ability : GameObject
    {
        private AbilityType type;
        private int resourceCost;
        private double damageAmount;
        private double healAmount;
        private string description;

        public Ability(string name, int resourceCost, double damageAmount, double healAmount, string description = null)           
        {
            this.Name = name;
            this.ResourceCost = resourceCost;
            this.DamageAmount = damageAmount;
            this.HealAmount = healAmount;
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

        public string Description {
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

        public double DamageAmount
        {
            get
            {
                return this.damageAmount;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Ability damage cannot be negative!");
                }

                this.damageAmount = value;
            }
        }

        public double HealAmount
        {
            get
            {
                return this.healAmount;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Ability Heal ammount cannot be negative!");
                }

                this.healAmount = value;
            }
        }

        public abstract void UseAbility();     
    }
}
