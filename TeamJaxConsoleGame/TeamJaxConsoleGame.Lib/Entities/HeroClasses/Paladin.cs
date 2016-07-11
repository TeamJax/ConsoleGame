namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;

    using Enumerations;

    public class Paladin : Hero
    {
        public Paladin(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating)
            : base(name, race, HeroType.Paladin, stamina, strenght, intelligence, agility, armorRating)
        {
            //this.Stamina = 160;
            //this.Strenght = 90;
            //this.Intelligence = 55;
            //this.Health = this.Strenght + this.Stamina;
            //this.Agility = 20;
            //this.ArmorRating = 40;
            //this.AttackDamage = this.Agility * 2 + this.Strenght;
        }

        public override void UseSpecialAbility()
        {
            this.Health += 50;
        }
    }
}
