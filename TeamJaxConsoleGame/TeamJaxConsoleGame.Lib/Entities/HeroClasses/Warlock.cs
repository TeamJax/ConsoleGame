namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class Warlock : Hero
    {
        public Warlock(string name, RaceType race) 
            : base(name, race)
        {
            this.Stamina = 80;
            this.Strenght = 50;
            this.Intelligence = 100;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = 50;
            this.ArmorRating = 20;
            this.AttackDamage = this.Agility * 2 + this.Intelligence;
        }
    }
}
