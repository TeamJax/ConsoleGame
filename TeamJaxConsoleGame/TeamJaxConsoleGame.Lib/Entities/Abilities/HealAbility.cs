namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;

    public class HealAbility : Ability
    {
        public HealAbility(string name, int resourceCost, double damageAmount, double healAmount, string description = null)
            : base(name, resourceCost, damageAmount, healAmount, description)
        {
        }

        public override void UseAbility()
        {
            throw new NotImplementedException();
        }
    }
}
