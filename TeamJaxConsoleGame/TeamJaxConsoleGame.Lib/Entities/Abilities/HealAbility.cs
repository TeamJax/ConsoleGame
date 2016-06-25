namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;

    public class HealAbility : Ability
    {
        public HealAbility(string name, int resourceCost, int power, string description = null)
            : base(name, resourceCost, power, description)
        {
        }

        public override void UseAbility(Hero targetHero)
        {
            targetHero.Health += this.AbilityPower;
        }
    }
}
