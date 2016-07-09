﻿namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class Warrior : Hero
    {
        public Warrior(string name, RaceType race, int stamina, int strenght, int intelligence, int agility, int armorRating) 
            : base(name, race,  stamina,  strenght,  intelligence,  agility,  armorRating)
        {
            this.Stamina = 200;
            this.Strenght = 120;
            this.Intelligence = 15;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = 30;
            this.ArmorRating = 50;
            this.AttackDamage = this.Agility * 2 + this.Strenght;
        }
    }
}
