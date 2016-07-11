namespace TeamJaxConsoleGame.Lib.Factory.GameSceneFactory
{
    using System.Collections.Generic;

    using Entities;
    using Enumerations;
    using Scenes;

    public class TownSceneFactory : GameSceneFactory
    {
        public override GameScene CreateScene(Hero hero, Location location)
        {
            Dictionary<string, GameSceneType> menuOptions = new Dictionary<string, GameSceneType>()
            {
                { GameSceneType.Invenotry.ToString(), GameSceneType.Invenotry  },
                { GameSceneType.Travel.ToString(), GameSceneType.Travel  },
                { GameSceneType.Forest.ToString(), GameSceneType.Forest  },
                { GameSceneType.Shop.ToString(), GameSceneType.Shop  }
            };

            return new TownScene(location, hero, GameSceneType.Town, menuOptions);
        }
    }
}
