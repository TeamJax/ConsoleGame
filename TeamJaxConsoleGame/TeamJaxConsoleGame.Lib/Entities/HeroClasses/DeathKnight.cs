namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class DeathKnight : Hero
    {
        public DeathKnight(string name, RaceType race) 
            : base(name, race)
        {
            this.Stamina = 150;
            this.Strenght = 100;
            this.Intelligence = 15;
            this.Health = this.Strenght + this.Stamina;
            this.Agility = 50;
            this.ArmorRating = 20;
            this.AttackDamage = this.Agility * 2 + this.Strenght;
        }
    }
}
