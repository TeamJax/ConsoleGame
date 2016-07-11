using TeamJaxConsoleGame.Lib.Enumerations;

namespace TeamJaxConsoleGame.Lib.Entities
{
    using Common;
    using Constants;
    using Interfaces;
    //todo remove this class and inherit hero
    public class Enemy : ItemHolder, IFighter
    {
        private int agility;
        private int armorRating;
        private int attackDamage;
        private int health;
        private int intelligence;
        private int stamina;
        private int strenght;

        public Enemy(string name, int armorRating, int attackDamage, int health, int agility, int stamina,int strenght, int intelligence)
        {
            this.ArmorRating = armorRating;
            this.Health = health;
            this.AttackDamage = attackDamage;
            this.Name = name;
        }

        public int Agility
        {
            get { return this.agility; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax, "Agility",
                    ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.agility = value;
            }
        }

        public int ArmorRating
        {
            get { return this.armorRating; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax, "ArmorRating",
                    ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.armorRating = value;
            }
        }

        public int AttackDamage
        {
            get { return this.attackDamage; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax, "AttackDamage",
                    ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.attackDamage = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax, "Health",
                    ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.health = value;
            }
        }

        public int Intelligence
        {
            get { return this.intelligence; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax, "Intelligence",
                    ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.intelligence = value;
            }
        }

        public int Stamina
        {
            get { return this.stamina; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax, "Stamina",
                    ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.stamina = value;
            }
        }

        public int Strenght
        {
            get { return this.strenght; }
            set
            {
                Validator.ValidateIntRange(value, ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength,
                    string.Format(ValidatorConstants.NumbersMustBeBetweenMinAndMax, "Strenght",
                    ValidatorConstants.MinStatLength, ValidatorConstants.MaxStatLength));

                this.strenght = value;
            }
        }

        public PrimaryHeroStatsType PrimaryStats { get; set; }
    }
}
