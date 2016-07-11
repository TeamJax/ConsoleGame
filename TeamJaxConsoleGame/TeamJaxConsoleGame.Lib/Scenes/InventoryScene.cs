namespace TeamJaxConsoleGame.Lib.Scenes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Entities;
    using Enumerations;
    using Resources;
    using ScreenText;

    public class InventoryScene : GameScene
    {
        public InventoryScene(Location currentLocation, Hero hero, GameSceneType sceneType, IDictionary<string, GameSceneType> optionsMenuItems)
            : base(currentLocation, hero, sceneType, optionsMenuItems, ConsoleColor.White)
        {
        }

        public override void DescribeScene()
        {
            var output = new StringBuilder();
            output.AppendLine(GameScreenResources.InvetoryDescription);
            output.AppendLine(this.Hero.GiveDescription());
            GameScreen.PrintOutput(output.ToString(), this.SceneColor);
            base.WriteOptionsMenu();
        }
    }
}
