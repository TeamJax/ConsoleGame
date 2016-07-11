namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory
{
    using System.Collections.Generic;
    using Entities;
    using Enumerations;    
    using Interfaces;

    public abstract class HeroFactory
    {
        public abstract Hero CreateHero(string name, RaceType race);

        public abstract IList<IAbility> DefinedHeroAbilities();

        public abstract IList<ISkill> DefinedHeroSkills();
    }
}
