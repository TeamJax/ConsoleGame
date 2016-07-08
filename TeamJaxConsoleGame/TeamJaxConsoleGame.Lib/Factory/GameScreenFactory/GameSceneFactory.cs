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

    public abstract class GameSceneFactory
    {
        public abstract GameScene CreateScene(Hero hero,string locationName, string locationDescription);
    }
}
