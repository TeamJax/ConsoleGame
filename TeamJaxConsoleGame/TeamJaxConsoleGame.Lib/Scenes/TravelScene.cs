namespace TeamJaxConsoleGame.Lib.Scenes
{
    using ScreenText;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TeamJaxConsoleGame.Lib.Entities;
    using TeamJaxConsoleGame.Lib.Enumerations;

    public class TravelScene : GameScene
    {
        private IDictionary<string, Locations> locationsOptions;

        public TravelScene(Location currentLocation, Hero hero, GameSceneType sceneType, IDictionary<string, GameSceneType> optionsMenuItems, IDictionary<string, Locations> locationsOptions)
            : base(currentLocation, hero, sceneType, optionsMenuItems, ConsoleColor.Green)
        {
            this.LocationsOptions = locationsOptions;
            this.UserTravelChoiceMenu = this.CreateLocationsUserChoiceMenu(this.locationsOptions); 
        }

        private IDictionary<string, Locations> LocationsOptions
        {
            get
            {
                return locationsOptions;
            }

            set
            {
                locationsOptions = value;
            }
        }
                
        private IDictionary<int, Locations> UserTravelChoiceMenu
        {
            get;
            set;
        }

        private IDictionary<int, Locations> CreateLocationsUserChoiceMenu(IDictionary<string, Locations> optionsMenuItems)
        {
            var userChoices = new SortedDictionary<int, Locations>();
            
            foreach (var item in optionsMenuItems)
            {
                userChoices.Add((int)item.Value, item.Value);
            }

            return userChoices;
        }
        

        public override void DescribeScene()
        {
            GameScreen.PrintMap();
            this.WriteOptionsMenu();
        }

        protected override void WriteOptionsMenu()
        {
            this.LocationsOptions.Keys.OrderBy(x => x);
            var output = new StringBuilder();

            foreach (var item in this.UserTravelChoiceMenu)
            {
                output.Append(String.Format("{0}.{1}; ", item.Key, item.Value));
            }

            output.AppendLine();
            GameScreen.PrintOutput(output.ToString(), this.SceneColor);


            base.WriteOptionsMenu();
        }
    }
}
