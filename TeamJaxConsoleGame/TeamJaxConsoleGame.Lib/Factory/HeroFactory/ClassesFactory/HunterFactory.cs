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
    
    public class HunterFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            var heroToCreate = new Hunter(
                name,
                race,
                HeroConstants.HUNTER_STAMINA,
                HeroConstants.HUNTER_STRENGTH,
                HeroConstants.HUNTER_INTELLIGENCE,
                HeroConstants.HUNTER_AGILITY,
                HeroConstants.HUNTER_ARMOR_RATING
                )
            {
                Abilities = this.DefinedHeroAbilities(),
                Skills = this.DefinedHeroSkills(),
                Items = Items()
            };

            return heroToCreate;
        }

        protected override IList<IAbility> DefinedHeroAbilities()
        {
            return new List<IAbility>
            {
                new HealAbility("Tranquilizing Shot", 20, 10, "Invigorates the hunter and heals him for a small amount"),
                new DamageAbility("Steady Shot", 10, 10, "A steady shot that causes physical damage"),
                new DamageAbility("Arcane Shot", 5, 15, "An instant shot that causes arcane damage"),
                new DamageAbility("Multi-Shot", 10, 20, "Fires several missiles at your target")
            };
        }

        protected override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Deterrence", 10, "Hunter has a 10% chacne to deflect incoming attacks"),
                new ActiveSkill("Trueshot Aura", 100, 10, "Increases hunter attack damage by 10%")
            };
        }

        protected override IList<IItem> Items()
        {
            return new List<IItem>
            {
                new Knife("Stiffing dagger", 30)
            };
        }
    }
}
