namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;

    public class DamageAbility : Ability
    {
        public DamageAbility(string name, int resourceCost, int power, string description = null) 
            : base(name, resourceCost, power, description)
        {
        }

        public override void UseAbility(Hero targetHero)
        {
            var inflictedDamage = 0; //add formula   
            
            targetHero.Health -= inflictedDamage;
        }
    }
}
