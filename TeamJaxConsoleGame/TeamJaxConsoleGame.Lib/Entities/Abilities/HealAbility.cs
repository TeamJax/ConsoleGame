namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using Enumerations;
    using Interfaces;
    using Abilities.Abstract;

    public class HealAbility : Ability, IGameObject
    {
        public HealAbility(string name, AbilityType type, int resourceCost, int abilityPower, string description = null) 
            : base(name, type, resourceCost, abilityPower, description)
        {
        }

        public override void Activate(IFighter target)
        {
            //todo check if invaldi hero selected
            target.Health += this.AbilityPower;
        }
    }
}
