namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;

    using Enumerations;

    public class Mage : Hero
    {
        public Mage(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating)
            : base(name, race, HeroType.Mage, stamina, strenght, intelligence, agility, armorRating)
        {
            this.Stamina = 50;
            this.Strenght = 100;
            this.Intelligence = 150;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = 15;
            this.ArmorRating = 5;
            this.AttackDamage = this.Agility * 2 + this.Intelligence;
        }

        public override void UseSpecialAbility()
        {
            throw new NotImplementedException();
        }
    }
}
