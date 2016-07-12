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
            output.AppendLine(GameScreenResources.InventoryDescription);
            output.AppendLine(this.Hero.GiveDescription());
            output.AppendLine();
            output.AppendLine(GameScreenResources.BreakRow);
            output.AppendLine(GameScreenResources.SkillsDescription);
            output.AppendLine(GameScreenResources.BreakRow);
            output.AppendLine();

            foreach (var skill in base.Hero.Skills)
            {
                output.Append(string.Format("{0} <:-:> {1}",skill.Name, skill.GiveDescription()));
                output.AppendLine();
            }

            output.AppendLine();
            output.AppendLine(GameScreenResources.BreakRow);
            output.AppendLine(GameScreenResources.AbilitiesDescription);
            output.AppendLine(GameScreenResources.BreakRow);
            output.AppendLine();

            foreach (var ability in base.Hero.Abilities)
            {
                output.Append(string.Format("{0} <=-=> {1}", ability.Name, ability.GiveDescription()));
                output.AppendLine();
            }

            output.AppendLine();
            output.AppendLine(GameScreenResources.BreakRow);
            output.AppendLine(GameScreenResources.ItemsDesciption);
            output.AppendLine(GameScreenResources.BreakRow);
            output.AppendLine();

            foreach (var item in base.Hero.Items)
            {
                output.Append(string.Format("{0} <=+=> {1}", item.Name, item.GiveDescription()));
                output.AppendLine();
            }

            GameScreen.PrintOutput(output.ToString(), this.SceneColor);
            base.WriteOptionsMenu();
        }
    }
}
