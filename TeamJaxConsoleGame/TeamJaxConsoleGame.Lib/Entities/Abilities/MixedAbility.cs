namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;
    using Enumerations;
    using Interfaces;

    public class MixedAbility : Ability
    {
        public MixedAbility(string name, AbilityType type, int resourceCost, int abilityPower, string description = null) 
            : base(name, type, resourceCost, abilityPower, description)
        {
        }

        public override void UseAbility()
        {
            targetHero.Health += this.AbilityPower;

        }
    }
}
