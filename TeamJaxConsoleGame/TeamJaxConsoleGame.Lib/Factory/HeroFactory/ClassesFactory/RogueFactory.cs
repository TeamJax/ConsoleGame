namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;
    using System.Collections.Generic;
    using Interfaces;

    public class RogueFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Rogue(
                name,
                race,
                HeroConstants.ROGUE_STAMINA,
                HeroConstants.ROGUE_STRENGTH,
                HeroConstants.ROGUE_INTELLIGENCE,
                HeroConstants.ROGUE_AGILITY,
                HeroConstants.ROGUE_ARMOR_RATING);
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
