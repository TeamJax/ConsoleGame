namespace TeamJaxConsoleGame.Lib.Enumerations
{
    using System.ComponentModel;

    public enum HeroType
    {
        [Description("Death Knight")]
        DeathKnight = 1,
        Hunter,
        Mage,
        Monk,
        Paladin,
        Priest,
        Rogue,
        Warlock,
        Warrior
    }
}
