namespace TeamJaxConsoleGame.Lib.Scenes
{
    using System;
    using System.Collections.Generic;

    using Entities;
    using Enumerations;
    using Resources;

    public class InventoryScene : GameScene
    {
        public InventoryScene(Location currentLocation, Hero hero, GameSceneType sceneType, IDictionary<string, GameSceneType> optionsMenuItems)
            : base(currentLocation, hero, sceneType, optionsMenuItems)
        {
        }

        public override void DescribeScene()
        {
            Console.WriteLine(GameScreenResources.InvetoryDescription);
            Console.WriteLine(this.Hero.GiveDescription());
            base.WriteOptionsMenu();
        }
    }
}
