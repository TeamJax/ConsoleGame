using System.Collections.Generic;
using TeamJaxConsoleGame.Lib.Interfaces;

namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory
{
    using Entities;
    using Enumerations;

    public abstract class HeroFactory
    {
        public abstract Hero CreateHero(string name, RaceType race);

        public abstract IList<IAbility> DefinedHeroSkills();

        public abstract IList<>
    }
}
