namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class Paladin : Hero
    {
        public Paladin(string name, RaceType race) 
            : base(name, race)
        {
            this.Stamina = 160;
            this.Strenght = 90;
            this.Intelligence = 55;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = 20;
            this.ArmorRating = 40;
            this.AttackDamage = this.Agility * 2 + this.Strenght;
        }
    }
}
