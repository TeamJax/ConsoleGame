namespace TeamJaxConsoleGame.Lib.Scenes
{
    using ScreenText;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Entities;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class TravelScene : GameScene
    {
        public TravelScene(Location currentLocation, Hero hero, GameSceneType sceneType, IDictionary<string, GameSceneType> optionsMenuItems)
            : base(currentLocation, hero, sceneType, optionsMenuItems)
        {

        }

        public override void DescribeScene()
        {
            GameScreen.PrintMap();
        }
    }
}
