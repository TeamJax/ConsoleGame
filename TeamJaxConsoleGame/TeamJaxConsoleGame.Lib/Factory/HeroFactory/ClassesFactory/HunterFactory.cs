namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;

    public class HunterFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Hunter(
                name,
                race,
                HeroConstants.HUNTER_STAMINA,
                HeroConstants.HUNTER_STRENGTH,
                HeroConstants.HUNTER_INTELLIGENCE,
                HeroConstants.HUNTER_AGILITY,
                HeroConstants.HUNTER_ARMOR_RATING);
        }
    }
}
