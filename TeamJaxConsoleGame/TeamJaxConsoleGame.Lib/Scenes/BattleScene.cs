namespace TeamJaxConsoleGame.Lib.Scenes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
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
            : base(currentLocation, hero, sceneType, optionsMenuItems)
        {
        }

        public override void DescribeScene()
        {
            base.DescribeScene();
        }
    }
}
