namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;

    using Enumerations;

    public class Hunter : Hero
    {
        public Hunter(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating) 
            : base(name, race, HeroType.Hunter, stamina, strenght, intelligence, agility, armorRating)
        {
        }

        public override void UseSpecialAbility()
        {
            this.Agility += 75;
        }
    }
}
