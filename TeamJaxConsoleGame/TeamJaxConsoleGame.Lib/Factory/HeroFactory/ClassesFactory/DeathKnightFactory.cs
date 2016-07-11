using TeamJaxConsoleGame.Lib.Entities.Skills;

namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using System.Collections.Generic;
    using Constants;
    using Entities;
    using Entities.Abilities;
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
                new DamageAbility("Death and Decay", 10, 50),
                new DamageAbility("Blood Boil", 20, 10),
                new DamageAbility("Icy Touch", 50, 30),
                new DamageAbility("Plague Strike", 40, 40),
                new HealAbility("Dark Simulacrum", 30, 40)
            };
        }

        public override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Dodge", 20),
                new PassiveSkill("Parry", 30),
                new ActiveSkill("Horn Of Winter", 100, 100, ),
            };            
        }
    }
}
