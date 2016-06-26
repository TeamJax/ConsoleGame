namespace TeamJaxConsoleGame.Lib.Interfaces
{
    public interface IFighter : IGameObject
    {
        int Health { get; set; }

        int AttackDamage { get; set; }

        int ArmorRating { get; set; }  
    }
}
