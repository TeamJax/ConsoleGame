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

    public class MageFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Mage(
                name,
                race,
                HeroConstants.MAGE_STAMINA,
                HeroConstants.MAGE_STRENGTH,
                HeroConstants.MAGE_INTELLIGENCE,
                HeroConstants.MAGE_AGILITY,
                HeroConstants.MAGE_ARMOR_RATING)
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
                new DamageAbility("Fire Ball", 10, 25, "Hurls a Fire Ball that cases fire damage to the target!"),
                new DamageAbility("PyroBlast", 15, 30 ,"Hurls Immense fiery boulder that crushes the enemy and burnts it alive!"),
                new DamageAbility("Arcane Blast", 10, 20,"Blast that launches strong arcane damage to the target!"),
                new DamageAbility("Frost Bolt", 15, 25, "Launches a frost bolt that freezes and damages the target!")

            };
        }

        protected override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Arcane Brilliance",50,"Infuses the target with arcane brilliance inscreasting their power!"),
                new ActiveSkill("Summon Water Elementa", 15, 40,"Summons a water elemental to fight for the caster!")
            };
        }

        protected override IList<IItem> Items()
        {
            return new List<IItem>
            {
                new Stick("Abberator", 200),
                new Pot("Healing pot", 5),
                new Pot("Mana pot", 10)
            };
        }
    }
}
