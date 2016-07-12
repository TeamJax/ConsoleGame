namespace TeamJaxConsoleGame.Lib.Factory.LocationEntitiesFactory
{
    using System;
    using TeamJaxConsoleGame.Lib.Entities;
    using TeamJaxConsoleGame.Lib.Interfaces;

    public class PandariaFactory : GameFactory
    {
        public override IFighter CreateEnemyEntity()
        {
            return new Enemy("Panda thug", 1, 2, 5,2,2,2,2);
        }

        public void CreateTrader()
        {
            throw new NotImplementedException();
        }
    }
}
