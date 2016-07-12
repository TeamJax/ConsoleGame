namespace TeamJaxConsoleGame.Lib.Interfaces
{
    using TeamJaxConsoleGame.Lib.Enumerations;

    public interface IItem : IGameObject
    {
        ItemType ItemType { get; set; }
        int Price { get; }
    }
}