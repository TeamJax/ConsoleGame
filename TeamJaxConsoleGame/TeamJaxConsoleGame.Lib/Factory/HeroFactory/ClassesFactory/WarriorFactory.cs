namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;

    public class WarriorFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Warrior(
                name,
                race,
                HeroConstants.WARRIROR_STAMINA,
                HeroConstants.WARRIROR_STRENGTH,
                HeroConstants.WARRIROR_INTELLIGENCE,
                HeroConstants.WARRIROR_AGILITY,
                HeroConstants.WARRIROR_ARMOR_RATING);
        }
    }
}
