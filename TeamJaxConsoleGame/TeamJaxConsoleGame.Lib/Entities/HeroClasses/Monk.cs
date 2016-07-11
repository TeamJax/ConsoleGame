namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using Enumerations;

    public class Monk : Hero
    {
        public Monk(string name, RaceType race,  int stamina, int strenght, int intelligence, int agility, int armorRating) 
            : base(name, race, HeroType.Monk, stamina, strenght, intelligence, agility, armorRating)
        {           
        }

        //todo Change method name to UseClassPowerup
        public override void UseSpecialAbility()
        {
            this.ArmorRating += 50;
        }
    }
}
