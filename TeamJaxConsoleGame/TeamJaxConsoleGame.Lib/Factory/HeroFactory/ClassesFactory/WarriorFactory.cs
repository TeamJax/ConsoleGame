

namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using System.Collections.Generic;
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;  
    using Interfaces;

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
