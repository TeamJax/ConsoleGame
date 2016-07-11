namespace TeamJaxConsoleGame.Lib.Factory
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Entities;

    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class TownFactory : GameFactory
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
