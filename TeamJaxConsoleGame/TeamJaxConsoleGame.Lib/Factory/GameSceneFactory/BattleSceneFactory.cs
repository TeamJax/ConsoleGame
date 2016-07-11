namespace TeamJaxConsoleGame.Lib.Factory.GameSceneFactory
{
    using Enumerations;
    using System.Collections.Generic;
    using TeamJaxConsoleGame.Lib.Entities;
    using TeamJaxConsoleGame.Lib.Scenes;

    public class BattleSceneFactory : GameSceneFactory
    {
        public override GameScene CreateScene(Hero hero, Location location)
        {
            Dictionary<string, GameSceneType> menuOptions = new Dictionary<string, GameSceneType>()
            {
                { GameSceneType.Invenotry.ToString(), GameSceneType.Invenotry },
                { GameSceneType.Travel.ToString(), GameSceneType.Travel },
                { GameSceneType.Forest.ToString(), GameSceneType.Forest },
                { GameSceneType.Shop.ToString(), GameSceneType.Shop }
            };

            //TODO:  Add BattleMenuOptions
            var battleOptions = new Dictionary<string, BattleSceneOptions>()
            {
                { BattleSceneOptions.Attack.ToString(),  BattleSceneOptions.Attack },
                { BattleSceneOptions.Abilities.ToString(), BattleSceneOptions.Abilities },
                { BattleSceneOptions.Skills.ToString(), BattleSceneOptions.Skills },
                { BattleSceneOptions.Items.ToString(), BattleSceneOptions.Items },
                { BattleSceneOptions.Run.ToString(), BattleSceneOptions.Run }
            };

            return new BattleScene(location, hero, GameSceneType.Battle, menuOptions, battleOptions);
        }
    }
}
