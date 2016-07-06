namespace TeamJaxConsoleGame.Lib.Entities.HeroClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class Rogue : Hero
    {
        public Rogue(string name, RaceType race) 
            : base(name, race)
        {
        }
    }
}
