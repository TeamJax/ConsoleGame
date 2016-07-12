namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory
{
    using System.Collections.Generic;
    using Entities;
    using Enumerations;    
    using Interfaces;

    public abstract class HeroFactory
    {
        public abstract Hero CreateHero(string name, RaceType race);

        protected abstract IList<IAbility> DefinedHeroAbilities();

        protected abstract IList<ISkill> DefinedHeroSkills();

        protected abstract IList<IItem> Items();
    }
}
