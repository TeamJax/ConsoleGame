namespace TeamJaxConsoleGame.Lib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Entities;
    using Enumerations;

    public class GameScene
    {
        //TODO: Use interfaces
        public GameScene(Location currentLocation, Hero hero, GameSceneType sceneType)
        {
            this.CurrentLocation = currentLocation;
            this.Hero = hero;
        }

        public Location CurrentLocation { get; set; }

        public Hero Hero { get; set; }

        public GameSceneType SceneType { get; set; }

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
