namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using System.Collections.Generic;
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;    
    using Interfaces;

    public class PriestFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Priest(
                name,
                race,
                HeroConstants.PRIEST_STAMINA,
                HeroConstants.PRIEST_STRENGTH,
                HeroConstants.PRIEST_INTELLIGENCE,
                HeroConstants.PRIEST_AGILITY,
                HeroConstants.PRIEST_ARMOR_RATING);
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
