namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using System.Collections.Generic;
    using Constants;
    using Entities;
    using Entities.Abilities;
    using Entities.HeroClasses;
    using Entities.Items;    
    using Entities.Skills;
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
                HeroConstants.PRIEST_ARMOR_RATING)
            {
                Abilities = DefinedHeroAbilities(),
                Skills = DefinedHeroSkills(),
                Items = Items()
            };
        }

        protected override IList<IAbility> DefinedHeroAbilities()
        {
            return new List<IAbility>
            {
                new DamageAbility("Mind Blast", 20, 25, "Blasts the target for Shadow damage!"),
                new DamageAbility("Shadow Word: Pain", 10, 15, "A word of darkness that causes Shadow damage and an additional  Shadow damage over 18 sec."),
                new DamageAbility("Mind Flay",10, 20, "Assault the target's mind with Shadow energy,Shadow damage over 3 sec."),
                new HealAbility("Penance", 5, 25, "Launches a volley of holy light at the target, causing Holy damage to an enemy and healing to an ally over 2 sec.")
            };
        }

        protected override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Mastery: Shield Discipline", 25, "Increases the potency of all your damage absorption spells, and all of your healing."),
                new ActiveSkill("Power Word: Fortitude", 5, 30, "Infuses the target with vitality, increasing Stamina by 10% for 1 hour.")

            };
        }

        protected override IList<IItem> Items()
        {
           return new List<IItem>
           {
               new Stick("Stick of Truth", 600)
           };
        }
    }
}
