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
                Skills = DefinedHeroSkills(),
                Items = Items()
            };

            return heroToCreate;
        }

        protected override IList<IAbility> DefinedHeroAbilities()
        {
            return new List<IAbility>
            {
                new DamageAbility("Death and Decay", 10, 50, "Corrupts the ground targeted by the Death Knight"),
                new DamageAbility("Blood Boil", 20, 10, "Makes target blood boild and causes a moderate amount of shadow damage"),
                new DamageAbility("Icy Touch", 50, 30, "Chills the target with frost damage"),
                new DamageAbility("Plague Strike", 40, 40, "Corrupts the target with shadow damage"),
                new HealAbility("Dark Simulacrum", 30, 40, "Places a heal ward on self and heals for a large amount of health")
            };
        }

        protected override IList<ISkill> DefinedHeroSkills()
        {
            return new List<ISkill>
            {
                new PassiveSkill("Dodge", 20, "Death knoght has 20% chance to dodge an incomming attack"),
                new PassiveSkill("Parry", 30, "Death knight has 30% chance to parry an incomming attack"),
                new ActiveSkill("Horn Of Winter", 100, 100, "Temporary increases death knight primary stats"),
                new ActiveSkill("Frost Presence", 5, 100, "Increases all of the death knight's stats by a small amount while active")           
            };            
        }

        protected override IList<IItem> Items()
        {
            return new List<IItem>
            {
               new Sword("Thunderfury", 200),
               new Pot("Healing Pot", 5),
               new Pot("Strength elixir", 5)
            };
        }
    }
}
