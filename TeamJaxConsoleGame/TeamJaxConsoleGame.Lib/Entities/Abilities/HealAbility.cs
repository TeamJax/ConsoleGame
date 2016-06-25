namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;
    using Enumerations;

    public class HealAbility : Ability
    {
        public HealAbility(string name, AbilityType type, int resourceCost, int abilityPower, string description = null) 
            : base(name, type, resourceCost, abilityPower, description)
        {
        }

        public override void UseAbility(Hero targetHero)
        {
            targetHero.Health += this.AbilityPower;
        }
    }
}
