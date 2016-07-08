namespace TeamJaxConsoleGame.Lib.Scenes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Entities;
    using Enumerations;

    public abstract class GameScene
    {
        private IDictionary<string, GameSceneType> optionsMenuItems;
        
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

        private void WriteOptionsMenu()
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
        internal abstract bool ValidateUserInput(ConsoleKeyInfo keyPressed);

        public virtual void DescribeScene()
        {
            Console.WriteLine(this.CurrentLocation.GiveDescriptionDescribe());
            Console.WriteLine(this.Hero.GiveDescriptionDescribe());
            this.WriteOptionsMenu();
        }
    }
}
