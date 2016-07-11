namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;

    public class PaladinFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Paladin(
                name,
                race,
                HeroConstants.PALADING_STAMINA,
                HeroConstants.PALADIN_STRENGTH,
                HeroConstants.PALADING_INTELLIGENCE,
                HeroConstants.PALADING_AGILITY,
                HeroConstants.PALADING_ARMOR_RATING);
        }
    }
}
