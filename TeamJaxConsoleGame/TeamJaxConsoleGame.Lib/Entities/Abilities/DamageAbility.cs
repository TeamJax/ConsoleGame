namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using Enumerations;
    using Interfaces;
    using Abilities.Abstract;

    public class DamageAbility : Ability, IGameObject
    {
        public DamageAbility(string name, int resourceCost, int abilityPower, string description) 
            : base(name, AbilityType.Damage, resourceCost, abilityPower, description)
        {
        }

        public override void Activate(IFighter target)
        {
            target.Health -= this.AbilityPower;
        }     
    }
}
