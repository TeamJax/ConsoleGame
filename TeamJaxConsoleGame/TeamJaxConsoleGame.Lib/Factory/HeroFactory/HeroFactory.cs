using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Entities;
using TeamJaxConsoleGame.Lib.Enumerations;

namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory
{
    public abstract class HeroFactory
    {
        public abstract Hero CreateHero(string name, RaceType race);
    }
}
