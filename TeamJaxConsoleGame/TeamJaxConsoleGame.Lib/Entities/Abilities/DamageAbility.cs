namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;
    using Enumerations;

    public class DamageAbility : Ability
    {
        public DamageAbility(string name, AbilityType type, int resourceCost, int abilityPower, string description = null) 
            : base(name, type, resourceCost, abilityPower, description)
        {
        }

        public override void UseAbility(Hero targetHero)
        {
            var inflictedDamage = 0; //add formula   
            
            targetHero.Health -= inflictedDamage;
        }
    }
}
