namespace TeamJaxConsoleGame.Lib.Factory.GameScreenFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TeamJaxConsoleGame.Lib.Entities;
    using TeamJaxConsoleGame.Lib.Enumerations;
    using TeamJaxConsoleGame.Lib.Scenes;

    public class SceneCreater
    {
        public SceneCreater()
        {
        }

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
                    sceneFactory = new TownSceneFactory();
                    location.LocationDescription = "Actually this is a town scene dicquised as an Invenotry. After we implement inventory - show inventory here";
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
