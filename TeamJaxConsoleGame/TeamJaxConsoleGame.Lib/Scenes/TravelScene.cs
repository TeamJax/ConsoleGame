namespace TeamJaxConsoleGame.Lib.Scenes
{
    using ScreenText;
    using System;
    using System.Collections.Generic;

    using TeamJaxConsoleGame.Lib.Entities;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class TravelScene : GameScene
    {
        public TravelScene(Location currentLocation, Hero hero, GameSceneType sceneType, IDictionary<string, GameSceneType> optionsMenuItems)
            : base(currentLocation, hero, sceneType, optionsMenuItems, ConsoleColor.Green)
        {
        }

        public override void DescribeScene()
        {
            GameScreen.PrintMap();
            this.WriteOptionsMenu();
        }
    }
}
