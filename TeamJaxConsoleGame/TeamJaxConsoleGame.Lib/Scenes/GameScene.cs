namespace TeamJaxConsoleGame.Lib.Scenes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Entities;
    using Enumerations;

    public abstract class GameScene
    {
        private IDictionary<string, GameSceneType> optionsMenuItems;

        //TODO: Use interfaces
        public GameScene(Location currentLocation, Hero hero, GameSceneType sceneType, IDictionary<string, GameSceneType> optionsMenuItems)
        {
            this.CurrentLocation = currentLocation;
            this.Hero = hero;
            this.OptionsMenuItems = optionsMenuItems;
        }

        public Location CurrentLocation { get; set; }

        public Hero Hero { get; set; }

        public GameSceneType SceneType { get; set; }

        public IDictionary<string, GameSceneType> OptionsMenuItems
        {
            get
            {
                //Lazy loading
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
        
        internal void WriteOptionsMenu()
        {
            this.OptionsMenuItems.Keys.OrderBy(x => x);
            var index = 1;
            foreach (var key in this.OptionsMenuItems.Keys)
            {
                Console.Write("{0}.{1}; ", index, key);
                index++;
            }
            Console.WriteLine();
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

            switch (this.SceneType)
            {
                case GameSceneType.Town:
                    //48 = key '0'
                    //49 = key '1'
                    //57 = key '9'
                    for (int i = 1; i <= 4; i++)
                    {
                        //TODO:
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
                    break;
                case GameSceneType.Forest:
                    break;
                case GameSceneType.Invenotry:
                    break;
                case GameSceneType.Battle:
                    break;
                case GameSceneType.Travel:
                    break;
                case GameSceneType.Shop:
                default:
                    break;
            }

            return returnValue;
        }
    }
}
