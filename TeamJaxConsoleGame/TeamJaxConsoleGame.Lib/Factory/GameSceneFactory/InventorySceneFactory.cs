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
    public class InventorySceneFactory : GameSceneFactory
    {
        public override GameScene CreateScene(Hero hero, Location location)
        {
            Dictionary<string, GameSceneType> menuOptions = new Dictionary<string, GameSceneType>()
            {
                { GameSceneType.Town.ToString(), GameSceneType.Town  },
                { GameSceneType.Travel.ToString(), GameSceneType.Travel },
                { GameSceneType.Forest.ToString(), GameSceneType.Forest },
                { GameSceneType.Shop.ToString(), GameSceneType.Shop }
            };

            return new InventoryScene(location, hero, GameSceneType.Invenotry, menuOptions);
        }
    }
}
