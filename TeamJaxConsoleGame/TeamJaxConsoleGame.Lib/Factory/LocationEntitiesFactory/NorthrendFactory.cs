namespace TeamJaxConsoleGame.Lib.Factory.LocationEntitiesFactory
{
    using Entities;
    using Interfaces;

    public class NorthrendFactory : GameFactory
    {
        public override IFighter CreateEnemyEntity()
        {
            return new Enemy("Ice Troll", 2, 4, 10,2,2,2,2);
        }
    }
}
