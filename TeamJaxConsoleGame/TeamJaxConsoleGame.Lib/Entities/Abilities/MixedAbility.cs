namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;
    using Enumerations;

    public class MixedAbility : Ability
    {
        public MixedAbility(string name, AbilityType type, int resourceCost, int abilityPower, string description = null) 
            : base(name, type, resourceCost, abilityPower, description)
        {
        }

        public override void UseAbility(Hero targetHero)
        {
            //todo damage target, heal self
        }
    }
}
