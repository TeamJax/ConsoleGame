namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory
{
    using Entities;
    using Enumerations;

    public abstract class HeroFactory
    {
        public abstract Hero CreateHero(string name, RaceType race);
    }
}
