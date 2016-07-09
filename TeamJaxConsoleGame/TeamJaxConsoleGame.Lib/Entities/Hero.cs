namespace TeamJaxConsoleGame.Lib.Entities
{
    using System;
    using System.Collections.Generic;

    using Abilities;
    using Interfaces;
    using Skills;
    using Constants;
    using Enumerations;

    public class Hero : ItemHolder, IFighter
    {
        private RaceType race;
        private int stamina;
        private int agility;
        private int intelligence;
        private int strenght;
              
        public Hero(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating )
        {
            this.Name = name;
            this.Health = HeroConstants.STARTING_HEALTH;
            this.AttackDamage = HeroConstants.ATTACK_DAMAGE;
            this.ArmorRating = HeroConstants.ARMOR_RATING;
            this.Skills = new List<IAbility>();
            this.Abilities = new List<Ability>();
            this.Race = race;
            this.Stamina = stamina;// 80;
            this.Strenght = strenght;// 50;
            this.Intelligence = intelligence; // 30;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = agility;// 100;
            this.ArmorRating = armorRating;// 10;
            this.AttackDamage = this.Agility * 2 + this.Strenght;
        }

        public RaceType Race { get; set; }

        public int Stamina { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public int Strenght { get; set; }

        public int Health { get; set; }

        public int AttackDamage { get; set; }

        public int ArmorRating { get; set; }  

        public IList<IAbility> Skills { get; set; }

        public IList<Ability> Abilities { get; set; }

        public override string GiveDescription()
        {
            return string.Format("You are {0}. A {1}. Another great hero seeking fortune and fame in the land of Teleriknia.", this.Name, this.Race);
        }
    }
}
