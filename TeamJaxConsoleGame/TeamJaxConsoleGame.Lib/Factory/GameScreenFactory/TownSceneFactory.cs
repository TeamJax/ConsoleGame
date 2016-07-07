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
        public override GameScene CreateScene(
            Location currentLocation,
            Hero hero,
            GameSceneType sceneType,
            IDictionary<string, GameSceneType> optionsMenuItems)
        {
            return new TownScene(currentLocation, hero, sceneType, optionsMenuItems);
        }
    }
}
