namespace TeamJaxConsoleGame.Lib.Factory.LocationEntitiesFactory
{
    using Interfaces;

    ///<summary>
    ///The 'AbstractFactory' abstract class
    ///</summary>
    public abstract class GameFactory
    {
        public abstract IFighter CreateEnemyEntity();
    }
}
