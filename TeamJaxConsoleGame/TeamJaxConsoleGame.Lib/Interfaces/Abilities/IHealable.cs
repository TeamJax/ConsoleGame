namespace TeamJaxConsoleGame.Lib.Interfaces.Abilities
{
    public interface IHealable<T>
    {
        T HealAmount(double amount);
    }
}
