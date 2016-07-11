namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;

    using Enumerations;

    public class DeathKnight : Hero
    {
        public DeathKnight(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating)
            : base(name, race, HeroType.DeathKnight, stamina, strenght, intelligence, agility, armorRating)
        {
            //TODO: use constants
            //this.Stamina = 150;
            //this.Strenght = 100;
            //this.Intelligence = 15;
            //this.Health = this.Strenght + this.Stamina;
            //this.Agility = 50;
            //this.ArmorRating = 20;
            //this.AttackDamage = this.Agility * 2 + this.Strenght;
        }

        public override void UseSpecialAbility()
        {
            this.Strenght += 100;
        }
    }
}
