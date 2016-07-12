namespace TeamJaxConsoleGame.Lib.Scenes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Entities;
    using Enumerations;
    using ScreenText;

    public abstract class GameScene
    {
        private IDictionary<string, GameSceneType> optionsMenuItems;
        private IDictionary<int, GameSceneType> userChoiceMenu;
        
        public GameScene(
            Location currentLocation,
            Hero hero, 
            GameSceneType sceneType,
            IDictionary<string, GameSceneType> optionsMenuItems, 
            ConsoleColor sceneColor)
        {
            this.CurrentLocation = currentLocation;
            this.Hero = hero;
            this.OptionsMenuItems = optionsMenuItems;
            this.UserChoiceMenu = this.CreateUserChoiceMenu(this.OptionsMenuItems);
            this.SceneColor = sceneColor;
        }

        public ConsoleColor SceneColor { get; set; }
        
        public Location CurrentLocation { get; set; }

        public Hero Hero { get; set; }

        public GameSceneType SceneType { get; set; }

        public IDictionary<string, GameSceneType> OptionsMenuItems
        {
            get
            {
                if (this.optionsMenuItems == null)
                {
                    this.optionsMenuItems = new Dictionary<string, GameSceneType>();
                }

                return this.optionsMenuItems;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("OptionsMenuItems can not be null");
                }

                this.optionsMenuItems = value;
            }
        }

        private IDictionary<int, GameSceneType> UserChoiceMenu
        {
            get
            {
                if (this.optionsMenuItems == null)
                {
                    this.userChoiceMenu = new Dictionary<int, GameSceneType>();
                }

                return this.userChoiceMenu;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("UserChoiceMenu can not be null");
                }

                this.userChoiceMenu = value;
            }
        }

        protected virtual void WriteOptionsMenu()
        {
            this.OptionsMenuItems.Keys.OrderBy(x => x);
            var output = new StringBuilder();

            foreach (var item in this.UserChoiceMenu)
            {
                output.Append(String.Format("{0}.{1}; ", item.Key, item.Value));
            }

            output.AppendLine();
            GameScreen.PrintOutput(output.ToString(), this.SceneColor);
        }

        protected IDictionary<int, GameSceneType> CreateUserChoiceMenu(IDictionary<string, GameSceneType> optionsMenuItems)
        {
            var userChoices = new SortedDictionary<int, GameSceneType>();

            var index = 1;
            foreach (var item in optionsMenuItems)
            {
                userChoices.Add(index, item.Value);
                index++;
            }

            return userChoices;
        }

        /// <summary>
        /// Town: 1.Inventory 2.Travel 3.Forest 4.Shop 
        /// Forest: 1.Inventory
        /// Invenotry: 1.Inventory
        /// Battle: 1.Inventory
        /// Shop: 1.Inventory
        /// Travel 1.Inventory
        /// </summary>
        /// <param name="keyPressed"></param>
        /// <returns></returns>
        internal bool ValidateUserInput(ConsoleKeyInfo keyPressed)
        {
            bool returnValue = false;

            //48 = key '0'
            //49 = key '1'
            //57 = key '9'
            for (int i = this.UserChoiceMenu.First().Key; i <= this.UserChoiceMenu.Last().Key; i++)
            {
                if (keyPressed.KeyChar == 48 + i)
                {
                    returnValue = true;
                    break;
                }
                else
                {
                    returnValue = false;
                }
            }

            return returnValue;
        }

        internal GameSceneType GetUserSelectedScene(ConsoleKeyInfo keyPressed)
        {
            var returnValue = this.UserChoiceMenu[keyPressed.KeyChar - 48];
            return returnValue;
        }

        public virtual void DescribeScene()
        {
            var output = new StringBuilder();
            output.AppendLine(this.CurrentLocation.GiveDescription());
            output.AppendLine(this.Hero.GiveDescription());
            GameScreen.PrintOutput(output.ToString(), this.SceneColor);
            this.WriteOptionsMenu();
        }
    }
}
