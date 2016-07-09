namespace TeamJaxConsoleGame.Lib.Factory.GameScreenFactory
{
    using Entities;
    using Enumerations;
    using Scenes;

    public class SceneCreater
    {
        public GameScene CreateScene(GameSceneType sceneType, Hero hero, Location location)
        {
            GameSceneFactory sceneFactory;

            switch (sceneType)
            {
                case GameSceneType.Town:
                    sceneFactory = new TownSceneFactory();
                    return sceneFactory.CreateScene(hero, location);
                //case GameSceneType.Forest:
                //    break;
                case GameSceneType.Invenotry:
                    sceneFactory = new InventorySceneFactory();
                    return sceneFactory.CreateScene(hero, location);
                //case GameSceneType.Battle:
                //    break;
                //case GameSceneType.Shop:
                //    break;
                //case GameSceneType.Travel:
                //    break;
                default:
                    return null;
            }
        }
    }
}
