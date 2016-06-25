namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;
    using Enumerations;
    using Interfaces.Abilities;

    public abstract class Ability : GameObject, IDamagable<Ability>, IHealable<Ability>
    {
        private AbilityType type;
        private int resourceCost;
        private double damageAmount;
        private double healAmount;
        private string description;

        public Ability(string name, int resourceCost, string description = null)           
        {
            this.Name = name;
            this.ResourceCost = resourceCost;
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

        public abstract void UseAbility();

        public virtual Ability DamageAmount(double amount)
        {
            throw new NotImplementedException();
        }

        public Ability HealAmount(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
