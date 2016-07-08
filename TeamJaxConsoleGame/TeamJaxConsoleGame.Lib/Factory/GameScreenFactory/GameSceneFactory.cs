﻿namespace TeamJaxConsoleGame.Lib.Factory.GameScreenFactory
{
    using Entities;
    using Scenes;

    public abstract class GameSceneFactory
    {
        public abstract GameScene CreateScene(Hero hero,Location locatiom);
    }
}
