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

    public class PaladinFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Paladin(
                name,
                race,
                HeroConstants.PALADING_STAMINA,
                HeroConstants.PALADIN_STRENGTH,
                HeroConstants.PALADING_INTELLIGENCE,
                HeroConstants.PALADING_AGILITY,
                HeroConstants.PALADING_ARMOR_RATING)
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
                new DamageAbility("Crusader Strinke", 10, 20, "An instant strike that causes Physical damage."),
                new DamageAbility("Judment Strike", 5, 15, " Causes Holy damage"),
                new DamageAbility("Hammer of Wraith", 15, 25, "Hurls a magical hammer that strikes an enemy for Holy damage"),
                new HealAbility("Holy Light", 10, 20, "Heals a friendly target!")
            };
        }

        protected override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Righteous Fury", 20, "Increases your threat generation while active, making you a more effective tank."),
                new ActiveSkill("Blessing of Might", 15, 20, " Places a Blessing on the friendly target, increasing stats by 50.")
            };
        }

        protected override IList<IItem> Items()
        {
            return new List<IItem>
            {
                new Shield("Dragonwrath", 5),
                new Sword("Thunderstomp", 150)
            };
        }
    }
}
