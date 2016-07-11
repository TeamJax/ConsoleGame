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
                HeroConstants.DEATH_KNIGHT_ARMOR_RATING)
            {
                Abilities = DefinedHeroAbilities(),
                Skills = DefinedHeroSkills()
            };


            return heroToCreate;
        }

        public override IList<IAbility> DefinedHeroAbilities()
        {
            return new List<IAbility>
            {
                new DamageAbility("Death and Decay", 10, 50, "Corrupts the ground targeted by the Death Knight"),
                new DamageAbility("Blood Boil", 20, 10, "Corrupts the ground targeted by the Death Knight"),
                new DamageAbility("Icy Touch", 50, 30, "Corrupts the ground targeted by the Death Knight"),
                new DamageAbility("Plague Strike", 40, 40, "Corrupts the ground targeted by the Death Knight"),
                new HealAbility("Dark Simulacrum", 30, 40, "Corrupts the ground targeted by the Death Knight")
            };
        }

        public override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Dodge", 20),
                new PassiveSkill("Parry", 30),
                new ActiveSkill("Horn Of Winter", 100, 100)            
            };            
        }
    }
}
