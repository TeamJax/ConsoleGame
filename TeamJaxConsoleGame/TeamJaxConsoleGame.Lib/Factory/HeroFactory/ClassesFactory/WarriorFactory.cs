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

    public class WarriorFactory : HeroFactory
    {
        public override Hero CreateHero(string name, RaceType race)
        {
            return new Warrior(
                name,
                race,
                HeroConstants.WARRIROR_STAMINA,
                HeroConstants.WARRIROR_STRENGTH,
                HeroConstants.WARRIROR_INTELLIGENCE,
                HeroConstants.WARRIROR_AGILITY,
                HeroConstants.WARRIROR_ARMOR_RATING)
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
                new DamageAbility("Mortal Strike", 5, 10, "A vicious strike that deals Physical damage!"),
                new DamageAbility("Slam", 10, 15, "Slam an opponent, causing Physical damage."),
                new DamageAbility("Sweeping Strikes", 15, 20, "Your melee attacks strike an additional nearby opponent for damage"),
                new HealAbility("Revenge", 10, 10, "Your attacks heal you for the damage dealth")
            };
        }

        protected override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Battle Shout", 15, "Increases the stats of all raid and party members!"),
                new ActiveSkill("BloodThirst", 10, 25, "Instantly strike the target for Physical damage")
            };
        }

        protected override IList<IItem> Items()
        {
            return new List<IItem>
            {
                new Sword("Thunderfury", 100),
                new Shield("Black Death", 50)
            };
        }
    }
}
