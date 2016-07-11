namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;

    public class WarlockFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Warlock(
                name,
                race,
                HeroConstants.WARLOCK_STAMINA,
                HeroConstants.WARLOCK_STRENGTH,
                HeroConstants.WARLOCK_INTELLIGENCE,
                HeroConstants.WARLOCK_AGILITY,
                HeroConstants.WARLOCK_ARMOR_RATING);
        }
    }
}
