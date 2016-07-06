namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class Warrior : Hero
    {
        public Warrior(string name, RaceType race) 
            : base(name, race)
        {
        }
    }
}
