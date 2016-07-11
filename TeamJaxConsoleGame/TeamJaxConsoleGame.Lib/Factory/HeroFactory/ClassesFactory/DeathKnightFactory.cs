using System.Collections.Generic;
using TeamJaxConsoleGame.Lib.Interfaces;

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
            var heroToCreate = new DeathKnight(
                name,
                race,
                HeroConstants.DEATH_KNIGHT_STAMINA,
                HeroConstants.DEATH_KNIGHT_STRENGHT,
                HeroConstants.DEATH_KNIGHT_INTELLIGENCE,
                HeroConstants.DEATH_KNIGHT_AGILITY,
                HeroConstants.DEATH_KNIGHT_ARMOR_RATING);

            heroToCreate.Abilities = DefinedHeroAbilities();
            heroToCreate.Skills = DefinedHeroSkills();

            return heroToCreate;
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
