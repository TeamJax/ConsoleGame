namespace TeamJaxConsoleGame.Lib.Interfaces
{
    using Enumerations;

    public interface IFighter : IGameObject
    {
        int Health { get; set; }

        int AttackDamage { get; set; }

        int ArmorRating { get; set; }

        int Stamina { get; set; }

        int Agility { get; set; }

        int Intelligence { get; set; }

        int Strenght { get; set; }

        PrimaryHeroStatsType PrimaryStats { get; set; }
    }
}
