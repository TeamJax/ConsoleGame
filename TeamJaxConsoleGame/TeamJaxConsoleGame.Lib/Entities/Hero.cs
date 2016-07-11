namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;
    using System.Collections.Generic;

    using Abilities;
    using Interfaces;
    using Skills;
    using Constants;
    using Enumerations;
    using Common;

    public abstract class Hero : ItemHolder, IFighter
    {
        private RaceType race;
        private int stamina;
        private int agility;
        private int intelligence;
        private int strenght;
        private int health;
        private int attackDamage;
        private int armorRating;
              
        public Hero(string name, RaceType race, HeroType type, int stamina, int strenght, int intelligence, int agility, int armorRating )
        {
            this.Name = name;
            this.Skills = new List<IAbility>();
            this.Abilities = new List<Ability>();
            this.Race = race;
            this.HeroType = type;
            this.Stamina = stamina;
            this.Strenght = strenght;
            this.Intelligence = intelligence;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = agility;
            this.ArmorRating = armorRating;
            this.AttackDamage = this.Agility * 2 + this.Strenght;
        }

        public RaceType Race { get; set; }

        public HeroType HeroType { get; set; }

        public int Stamina
        {
            get { return this.stamina; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax,
                    "Stamina", ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.stamina = value;
            }
        }

        public int Agility
        {
            get { return this.agility; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax,
                    "Agility", ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.agility = value;
            }
        }

        public int Intelligence
        {
            get { return this.intelligence; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax,
                    "Intelligence", ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.intelligence = value;
            }
        }

        public int Strenght
        {
            get { return this.strenght; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax,
                    "Strenght", ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.strenght = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax,
                    "Health", ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.health = value;
            }
        }

        public int AttackDamage
        {
            get { return this.attackDamage; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax,
                    "AttackDamage", ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.attackDamage = value;
            }
        }

        public int ArmorRating
        {
            get { return this.armorRating; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax,
                    "ArmorRating", ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.armorRating = value;
            }
        }

        public IList<IAbility> Skills { get; set; }

        public IList<Ability> Abilities { get; set; }

        public abstract void UseSpecialAbility();

        public override string GiveDescription()
        {
            return string.Format("You are {0}. A {1} {2}. Another great hero seeking fortune and fame in the land of Teleriknia.", this.Name, this.Race, this.HeroType);
        }

    }
}
