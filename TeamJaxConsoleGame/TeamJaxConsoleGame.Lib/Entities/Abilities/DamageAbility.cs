namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using Enumerations;
    using Interfaces;

    public class DamageAbility : Ability, IGameObject
    {
        public DamageAbility(string name, AbilityType type, int resourceCost, int abilityPower, string description = null) 
            : base(name, type, resourceCost, abilityPower, description)
        {
        }

        public override void Activate(IFighter target)
        {
            target.Health -= this.AbilityPower;
        }     
    }
}
