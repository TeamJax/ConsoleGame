namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;

    public class DeathKnightFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new DeathKnight(
                name,
                race,
                HeroConstants.DEATH_KNIGHT_STAMINA,
                HeroConstants.DEATH_KNIGHT_STRENGHT,
                HeroConstants.DEATH_KNIGHT_INTELLIGENCE,
                HeroConstants.DEATH_KNIGHT_AGILITY,
                HeroConstants.DEATH_KNIGHT_ARMOR_RATING);
        }
    }
}
