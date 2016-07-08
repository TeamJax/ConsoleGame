namespace TeamJaxConsoleGame.Lib.Scenes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Entities;
    using Enumerations;

    public class TownScene : GameScene
    {
        public TownScene(Location currentLocation, Hero hero, GameSceneType sceneType, IDictionary<string, GameSceneType> optionsMenuItems)
            : base(currentLocation, hero, sceneType, optionsMenuItems)
        {
        }

        /// <summary>
        /// Town: 1.Inventory 2.Travel 3.Forest 4.Shop 
        /// </summary>
        /// <param name="keyPressed">The user choice</param>
        /// <returns></returns>
        internal override bool ValidateUserInput(ConsoleKeyInfo keyPressed)
        {
            bool returnValue = false;

            //48 = key '0'
            //49 = key '1'
            //57 = key '9'
            for (int i = 1; i <= 4; i++)
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
    }
}
