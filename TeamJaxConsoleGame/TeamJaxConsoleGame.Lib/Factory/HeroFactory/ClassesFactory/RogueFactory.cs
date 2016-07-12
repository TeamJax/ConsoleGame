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

    public class RogueFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Rogue(
                name,
                race,
                HeroConstants.ROGUE_STAMINA,
                HeroConstants.ROGUE_STRENGTH,
                HeroConstants.ROGUE_INTELLIGENCE,
                HeroConstants.ROGUE_AGILITY,
                HeroConstants.ROGUE_ARMOR_RATING)
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
                new DamageAbility("Mutilate",5, 10, "Attack with both weapons, dealing damage with the main-hand and damage with the off-hand."),
                new DamageAbility("Backstab", 10, 10, "Backstab the target, causing Physical damage.  Must not be in front of the target"),
                new DamageAbility("Killing Spree", 20, 25, "Destroying evertyhing spreee physical dmg everywhere!"),
                new HealAbility("Recuperate", 10, 15, "Finishing move that restores of maximum health every 3 sec")
            };
        }

        protected override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Swiftblade's Cunning", 20, "Increases stats of all party and raid members."),
                new ActiveSkill("Stealth", 25, 30, "Conceals you in the shadows until cancelled, allowing you to stalk enemies without being seen.")
            };
        }

        protected override IList<IItem> Items()
        {
            return new List<IItem>
            {
                new Knife("Blade of azzinoth", 200),
                new Knife("Blade of azzinoth", 200)
            };
        }
    }
}
