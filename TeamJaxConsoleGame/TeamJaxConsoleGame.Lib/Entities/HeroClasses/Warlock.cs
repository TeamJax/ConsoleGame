namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using Enumerations;

    public class Warlock : Hero
    {
        public Warlock(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating) 
            : base(name, race, HeroType.Warlock,  stamina,  strenght,  intelligence,  agility,  armorRating)
        {
        }

        public override void UseSpecialAbility()
        {
            this.Intelligence += 50;
        }
    }
}
