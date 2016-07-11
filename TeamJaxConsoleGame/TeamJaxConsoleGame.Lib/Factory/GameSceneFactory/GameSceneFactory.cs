namespace TeamJaxConsoleGame.Lib.Factory.GameSceneFactory
{
    using Entities;
    using Scenes;

    public abstract class GameSceneFactory
    {
        public abstract GameScene CreateScene(Hero hero,Location location);
    }
}
