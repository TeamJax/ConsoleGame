namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;

    using Enumerations;

    public class Priest : Hero
    {
        public Priest(string name, RaceType race,  int stamina, int strenght, int intelligence, int agility, int armorRating)
            : base(name, race, HeroType.Priest, stamina, strenght, intelligence, agility, armorRating)
        {
            //this.Stamina = 60;
            //this.Strenght = 40;
            //this.Intelligence = 100;
            //this.Health = this.Strenght + this.Stamina;
            //this.Agility = 50;
            //this.ArmorRating = 20;
            //this.AttackDamage = this.Agility * 2 + this.Intelligence;
        }

        public override void UseSpecialAbility()
        {
            throw new NotImplementedException();
        }
    }
}
