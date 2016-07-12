namespace TeamJaxConsoleGame.Lib.Factory.LocationEntitiesFactory
{
    using System;
    using Interfaces;
    using TeamJaxConsoleGame.Lib.Entities;

    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class KalimdorFactory : GameFactory
    {
        public override IFighter CreateEnemyEntity()
        {
            return new Enemy("Town thief", 1, 2, 5,2,2,2,2);
        }

        public void CreateTrader()
        {
            throw new NotImplementedException();
        }
    }
}
