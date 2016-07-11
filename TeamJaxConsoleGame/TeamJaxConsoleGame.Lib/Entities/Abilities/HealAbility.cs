namespace TeamJaxConsoleGame.Lib.Entities.Abilities
{
    using Enumerations;
    using Interfaces;
    using Abilities.Abstract;

    public class HealAbility : Ability, IGameObject
    {
        public HealAbility(string name, int resourceCost, int abilityPower, string description) 
            : base(name, AbilityType.Heal, resourceCost, abilityPower, description)
        {
        }

        public override void Activate(IFighter target)
        {
            //todo check if invaldi hero selected
            target.Health += this.AbilityPower;
        }
    }
}
