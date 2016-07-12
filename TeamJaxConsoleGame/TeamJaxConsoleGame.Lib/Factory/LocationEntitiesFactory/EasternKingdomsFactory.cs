namespace TeamJaxConsoleGame.Lib.Factory.LocationEntitiesFactory
{
    using TeamJaxConsoleGame.Lib.Entities;
    using TeamJaxConsoleGame.Lib.Interfaces;

    public class EasternKingdomsFactory : GameFactory
    {
        public override IFighter CreateEnemyEntity()
        {
            return new Enemy("Dire wolf", 2, 4, 10, 2, 2, 2, 2);
        }
    }
}
