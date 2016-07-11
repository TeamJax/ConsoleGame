namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;

    using Enumerations;

    public class Rogue : Hero
    {
        public Rogue(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating) 
            : base(name, race, HeroType.Rogue, stamina,  strenght,  intelligence,  agility,  armorRating)
        {
            //this.Stamina = 100;
            //this.Strenght = 50;
            //this.Intelligence = 15;
            //this.Health = this.Strenght + this.Stamina;
            //this.Agility = 100;
            //this.ArmorRating = 10;
            //this.AttackDamage = this.Agility * 2 + this.Strenght;
        }

        public override void UseSpecialAbility()
        {
            this.Agility += 85;
        }
    }
}
