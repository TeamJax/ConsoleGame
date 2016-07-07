namespace TeamJaxConsoleGame.Lib.Scenes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Entities;
    using Enumerations;

    public class TownScene : GameScene
    {
        public TownScene(Location currentLocation, Hero hero, GameSceneType sceneType, IDictionary<string, GameSceneType> optionsMenuItems) 
            : base(currentLocation, hero, sceneType, optionsMenuItems)
        {
        }
    }
}
