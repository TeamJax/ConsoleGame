namespace TeamJaxConsoleGame.Lib.Factory
{
    using System;

    using Entities;
    using Interfaces;

    public class ForestFactory : GameFactory
    {
        public override IFighter CreateEnemyEntity()
        {
            return new Enemy("Forest Bandit", 2, 4, 10);
        }
    }
}
