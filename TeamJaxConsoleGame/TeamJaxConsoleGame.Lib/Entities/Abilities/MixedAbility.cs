namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;

    public class MixedAbility : Ability
    {
        public MixedAbility(string name, int resourceCost, double damageAmount, double healAmount, string description = null) 
            : base(name, resourceCost, damageAmount, healAmount, description)
        {
        }

        public override void UseAbility()
        {
            throw new NotImplementedException();
        }
    }
}
