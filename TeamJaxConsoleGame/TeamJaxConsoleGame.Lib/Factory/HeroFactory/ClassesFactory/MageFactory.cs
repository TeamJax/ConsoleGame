namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;

    public class MageFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Mage(
                name,
                race,
                HeroConstants.MAGE_STAMINA,
                HeroConstants.MAGE_STRENGTH,
                HeroConstants.MAGE_INTELLIGENCE,
                HeroConstants.MAGE_AGILITY,
                HeroConstants.MAGE_ARMOR_RATING);
        }
    }
}
