using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Entities;
using TeamJaxConsoleGame.Lib.Enumerations;
using TeamJaxConsoleGame.Lib.Scenes;

namespace TeamJaxConsoleGame.Lib.Factory.GameSceneFactory
{
    public class TravelSceneFactory : GameSceneFactory
    {
        public override GameScene CreateScene(Hero hero, Location location)
        {
            Dictionary<string, GameSceneType> menuOptions = new Dictionary<string, GameSceneType>()
            {
                { "Inventory", GameSceneType.Invenotry  },
                { "Travel", GameSceneType.Travel  },
                { "Forest", GameSceneType.Forest  },
                { "Shop", GameSceneType.Shop  }
            };

            return new TravelScene(location, hero, GameSceneType.Travel, menuOptions);
        }
    }
}
