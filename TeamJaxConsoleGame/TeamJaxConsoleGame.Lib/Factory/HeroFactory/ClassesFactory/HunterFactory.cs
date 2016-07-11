namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;
    using System.Collections.Generic;
    using Interfaces;

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

        public override IList<IAbility> DefinedHeroAbilities()
        {
            throw new System.NotImplementedException();
        }

        public override IList<ISkill> DefinedHeroSkills()
        {
            throw new System.NotImplementedException();
        }
    }
}
