﻿namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class Hunter : Hero
    {
        public Hunter(string name, RaceType race) 
            : base(name, race)
        {
            this.Stamina = 80;
            this.Strenght = 50;
            this.Intelligence = 30;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = 100;
            this.ArmorRating = 10;
            this.AttackDamage = this.Agility * 2 + this.Strenght;
        }
    }
}
