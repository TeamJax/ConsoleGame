namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;

    using Enumerations;

    public class Hunter : Hero
    {
        public Hunter(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating ) 
            : base(name, race, HeroType.Hunter, stamina, strenght, intelligence, agility, armorRating)
        {
            //this.Stamina = 80;
            //this.Strenght = 50;
            //this.Intelligence = 30;
            //this.Health = this.Strenght + this.Stamina;
            //this.Agility = 100;
            //this.ArmorRating = 10;
            //this.AttackDamage = this.Agility * 2 + this.Strenght;
        }

        public override void UseSpecialAbility()
        {
            throw new NotImplementedException();
        }
    }
}
