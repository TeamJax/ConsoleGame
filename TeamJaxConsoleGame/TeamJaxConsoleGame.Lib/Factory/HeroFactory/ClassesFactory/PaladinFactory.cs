namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using System.Collections.Generic;
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;    
    using Interfaces;

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
