namespace TeamJaxConsoleGame.Lib.Scenes
{
    using System;
    using System.Collections.Generic;
    using TeamJaxConsoleGame.Lib.Entities;
    using TeamJaxConsoleGame.Lib.Enumerations;

    class BattleScene : GameScene
    {
        public BattleScene(
            Location currentLocation,
            Hero hero, 
            GameSceneType sceneType, 
            IDictionary<string, GameSceneType> optionsMenuItems,
            IDictionary<string, BattleSceneOptions> battleOptions) 
            : base(currentLocation, hero, sceneType, optionsMenuItems, ConsoleColor.Red)
        {
        }

        public override void DescribeScene()
        {
            base.DescribeScene();
        }
    }
}
