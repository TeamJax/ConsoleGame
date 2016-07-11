namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;

    public class MonkFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Monk(
                name,
                race,
                HeroConstants.MONK_STAMINA,
                HeroConstants.MONK_STRENGTH,
                HeroConstants.MONK_INTELLIGENCE,
                HeroConstants.MONK_AGILITY,
                HeroConstants.MONK_ARMOR_RATING);
        }
    }
}
