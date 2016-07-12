namespace TeamJaxConsoleGame.Lib.Interfaces
{
    using Enumerations;

    public interface IAbility : IGameObject, IActivatable
    {
        AbilityType Type { get; set; }

        int ResourceCost { get; set; }

        int AbilityPower { get; set; } 

        string Description { get; set; }
    }
}
