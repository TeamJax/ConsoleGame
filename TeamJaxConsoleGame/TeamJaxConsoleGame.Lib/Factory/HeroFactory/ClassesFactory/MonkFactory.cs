namespace TeamJaxConsoleGame.Lib.Factory.HeroFactory.ClassesFactory
{
    using System.Collections.Generic;
    using Constants;
    using Entities;
    using Entities.HeroClasses;
    using Entities.Items;
    using Entities.Abilities;
    using Entities.Skills;
    using Enumerations;
    using Interfaces;

    public class MonkFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Monk(
                name,
                race,
                HeroConstants.MONK_STAMINA,
                HeroConstants.MONK_STRENGTH,
                HeroConstants.MONK_INTELLIGENCE,
                HeroConstants.MONK_AGILITY,
                HeroConstants.MONK_ARMOR_RATING)
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
                new DamageAbility("Fists of Fury", 20, 25, "Pummel all targets in front of you, stunning them and dealing damage!"),
                new DamageAbility("Tiger Palm", 10, 20, "Attack with the palm of your hand, dealing damange!"),
                new DamageAbility("Blackout Kick", 10, 15, "Kick with a blast of Chi energy, dealing damange"),
                new HealAbility("Soothing Mist", 5, 10, "Heals the target for  over 8 sec!")
            };
        }

        protected override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Stance of the Fierce Tiger", 30, "Grants you and your allies within 10 yards 10% increased movement speed!"),
                new ActiveSkill("Fortifying Brew", 20, 25, "Reduces damage taken and increases maximum health by 20% for 15 seconds!")
            };
        }

        protected override IList<IItem> Items()
        {
            return new List<IItem>
            {
                new Stick("Exceptional stick", 40),
                new Pot("Healing pot", 5)
            };
        }
    }
}
