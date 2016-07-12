namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using System.Collections.Generic;
    using Constants;
    using Entities;    
    using Entities.Abilities;
    using Entities.HeroClasses;
    using Entities.Skills;
    using Entities.Items;
    using Enumerations;
    using Interfaces;

    public class WarlockFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Warlock(
                name,
                race,
                HeroConstants.WARLOCK_STAMINA,
                HeroConstants.WARLOCK_STRENGTH,
                HeroConstants.WARLOCK_INTELLIGENCE,
                HeroConstants.WARLOCK_AGILITY,
                HeroConstants.WARLOCK_ARMOR_RATING)
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
                new DamageAbility("Immolate",15, 20, "Burns an enemy, then inflicts additional Fire damage!"),
                new DamageAbility("Incinerate", 10, 15, "Deals Fire damage to an enemy"),
                new DamageAbility("Shadow Bolt", 5, 10, "Inflicts the target with shadow damage"),
                new HealAbility("Drain Soul", 5, 15, "Inflicts the target with shadow damage transfering it in heal!")
            };
        }

        protected override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Eradication", 20, "You gain stats from all sources."),
                new ActiveSkill("Ritual of Summoning",20, 25, "Begins a ritual to create a summoning portal")
            };
        }

        protected override IList<IItem> Items()
        {
            return new List<IItem>
            {
                new Stick("Aggonizing Stick", 50),
                new Pot("Mana Pot", 15)
            };
        }
    }
}
