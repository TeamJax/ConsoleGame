using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamJaxConsoleGame.Lib.Entities;
using TeamJaxConsoleGame.Lib.Enumerations;
using TeamJaxConsoleGame.Lib.Scenes;

namespace TeamJaxConsoleGame.Lib.Factory.GameScreenFactory
{
    public class TownSceneFactory : GameSceneFactory
    {
        public override GameScene CreateScene(Hero hero,string locationName, string locationDescription)
        {
            var townFactory = new TownFactory();
            var townLocation = new Location(locationName, locationDescription, townFactory);
            
            townLocation.LocationObjects.Add(townLocation.LocationFacotry.CreateEnemyEntity());
            Dictionary<string, GameSceneType> menuOptions = new Dictionary<string, GameSceneType>()
            {
                { "Inventory", GameSceneType.Invenotry  },
                { "Travel", GameSceneType.Travel  },
                { "Forest", GameSceneType.Forest  },
                { "Shop", GameSceneType.Shop  }
            };

            return new TownScene(townLocation, hero, GameSceneType.Town, menuOptions);
        }
    }
}
