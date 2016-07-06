namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class Mage : Hero
    {
        public Mage(string name, RaceType race) 
            : base(name, race)
        {
            this.Stamina = 50;
            this.Strenght = 100;
            this.Intelligence = 150;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = 15;
            this.ArmorRating = 5;
            this.AttackDamage = this.Agility * 2 + this.Intelligence;
        }
    }
}
