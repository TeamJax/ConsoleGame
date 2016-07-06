namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class Monk : Hero
    {
        public Monk(string name, RaceType race) 
            : base(name, race)
        {
            this.Stamina = 180;
            this.Strenght = 110;
            this.Intelligence = 25;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = 80;
            this.ArmorRating = 35;
            this.AttackDamage = this.Agility * 2 + this.Strenght;
        }
    }
}
