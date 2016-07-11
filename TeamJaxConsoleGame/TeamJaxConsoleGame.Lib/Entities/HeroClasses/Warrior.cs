﻿namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using Enumerations;

    public class Warrior : Hero
    {
        public Warrior(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating) 
            : base(name, race, HeroType.Warrior, ResourceType.Rage, stamina,  strenght,  intelligence,  agility,  armorRating)
        {
        }

        public override void UseSpecialAbility()
        {
            this.Stamina += 50;
        }
    }
}
