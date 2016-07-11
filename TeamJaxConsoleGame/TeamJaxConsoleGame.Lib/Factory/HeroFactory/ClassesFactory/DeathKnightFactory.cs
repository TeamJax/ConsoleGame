using TeamJaxConsoleGame.Lib.Entities.Abilities;

namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using System.Collections.Generic;
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Enumerations;
    using Interfaces;

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
            return new List<IAbility>
            {
                new DamageAbility("Death and Decay", )
            };
        }

        public override IList<ISkill> DefinedHeroSkills()
        {
            throw new System.NotImplementedException();
        }
    }
}
