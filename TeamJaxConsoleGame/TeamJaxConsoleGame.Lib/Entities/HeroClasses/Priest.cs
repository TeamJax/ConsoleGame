﻿namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using Enumerations;

    public class Priest : Hero
    {
        public Priest(string name, RaceType race,  int stamina, int strenght, int intelligence, int agility, int armorRating)
            : base(name, race, HeroType.Priest, ResourceType.Mana, stamina, strenght, intelligence, agility, armorRating)
        {
        }

        public override void UseSpecialAbility()
        {
            this.Intelligence += 100;
        }
    }
}
