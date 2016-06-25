namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using System;

    public class MixedAbility : Ability
    {
        public MixedAbility(string name, int resourceCost, int power, string description = null) 
            : base(name, resourceCost, power, description)
        {
        }

        public override void UseAbility(Hero targetHero)
        {
            //todo damage target, heal self
        }
    }
}
